package com.example.crowdtranslator;

import java.util.ArrayList;
import com.Wsdl2Code.WebServices.ServiceMobile.JobDto;
import com.Wsdl2Code.WebServices.ServiceMobile.RecruiteeDto;
import com.Wsdl2Code.WebServices.ServiceMobile.ServiceMobile;
import com.Wsdl2Code.WebServices.ServiceMobile.SkillDto1;
import com.Wsdl2Code.WebServices.ServiceMobile.VectorRecruiteeDto;
import com.julian.controls.CustomDialog;

import android.app.Activity;
import android.app.Fragment;
import android.app.ProgressDialog;
import android.content.Intent;
import android.os.AsyncTask;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.View.OnClickListener;
import android.view.ViewGroup;
import android.view.ViewGroup.LayoutParams;
import android.widget.Button;
import android.widget.RadioButton;
import android.widget.RadioGroup;

public class LevelActivity extends Activity {
	
	private static ArrayList<SkillDto1> skills;
	private static ArrayList<JobDto> jobs;
	private static RecruiteeDto recruitee;


	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_level);
		if (savedInstanceState == null) {
			getFragmentManager().beginTransaction()
					.add(R.id.container, new PlaceholderFragment()).commit();
		}	
	}
	
	@SuppressWarnings("unchecked")
	public void onStart()
	{
		super.onStart();
		
		Bundle receiveBundle = this.getIntent().getExtras();
		if(recruitee == null)
		{
			recruitee = (RecruiteeDto)receiveBundle.getSerializable("recruitee");
			jobs = (ArrayList<JobDto>)receiveBundle.getSerializable("jobs");
			skills = (ArrayList<SkillDto1>)receiveBundle.getSerializable("skills");
		}
		
	}
	
	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.level, menu);
		return true;
	}
	
	

	@Override
	public boolean onOptionsItemSelected(MenuItem item) {
		// Handle action bar item clicks here. The action bar will
		// automatically handle clicks on the Home/Up button, so long
		// as you specify a parent activity in AndroidManifest.xml.
		int id = item.getItemId();
		if (id == R.id.action_settings) {
			return true;
		}
		return super.onOptionsItemSelected(item);
	}

	/**
	 * A placeholder fragment containing a simple view.
	 */
	public static class PlaceholderFragment extends Fragment implements OnClickListener{

		public PlaceholderFragment() {
		}

		@Override
		public View onCreateView(LayoutInflater inflater, ViewGroup container,
				Bundle savedInstanceState) {
			View rootView = inflater.inflate(R.layout.fragment_level,
					container, false);
			
			((Button)rootView.findViewById(R.id.btnNext)).setOnClickListener(this);

			return rootView;
		}
		
		public void onStart()
		{
			super.onStart();
			populateSkills(skills);
		}
		
		protected void startSurveyActivity()
		{
			Intent intent = new Intent(this.getActivity(), SurveyActivity.class);
	        Bundle sendBundle = new Bundle();
        	sendBundle.putSerializable("jobs", jobs);
        	sendBundle.putSerializable("recruitee", recruitee);
        	intent.putExtras(sendBundle);
            this.startActivity(intent);
            this.getActivity().finish();
		}
		
		public void onClick(View v) 
		{			
			if(v.equals((Button)this.getView().findViewById(R.id.btnNext)))
			{
				(new SkillConnection()).execute();
			}

		}
		
		protected void populateSkills(ArrayList<SkillDto1> skills)
		{
			RadioGroup rg = ((RadioGroup)getView().findViewById(R.id.rgSkill));
			RadioGroup.LayoutParams rprms;

			if(skills != null && rg.getChildCount() == 0)
			{
	            int row = 1;
				for(SkillDto1 sk : skills)
				{			
					RadioButton rdbtn = new RadioButton(getActivity());
					if(row == 1)
	                {
	                	rdbtn.setChecked(true);
	                }
	                rdbtn.setId(row++);
	                rdbtn.setText(sk.skillName);
	                rdbtn.setTag(sk.skillId);
	                rdbtn.setTextAppearance(getActivity(), android.R.style.TextAppearance_Medium);
	                rprms= new RadioGroup.LayoutParams(LayoutParams.WRAP_CONTENT, LayoutParams.WRAP_CONTENT);
	                rg.addView(rdbtn, rprms);
	            }
			}
			else
			{
				new CustomDialog(getActivity(), "Check your internet connection and try again!", "Could not retrieve data!");
			}
		}
	
		protected class SkillConnection extends AsyncTask<Void, Void, Void>
		{
			private ProgressDialog dialog;	
			private boolean completedWithError = false;
			protected void onPreExecute()
			{
				dialog = ProgressDialog.show(getView().getContext(), "Please Wait", "Retrieving Data", true);
			}
			
			@Override
			protected Void doInBackground(Void... params) {
				// TODO Auto-generated method stub
				try
				{
					ServiceMobile svc = new ServiceMobile();
					
					RadioGroup rg = ((RadioGroup)getView().findViewById(R.id.rgSkill));
					RadioButton rbChecked = (RadioButton)rg.findViewById(rg.getCheckedRadioButtonId());
					String skillId = (String)rbChecked.getTag();
					svc.addSkillToRecruitee(recruitee.recruiteeId, skillId);
					
					VectorRecruiteeDto recruitees = svc.selectRecruiteeBySkillId(skillId);
					
					
					Boolean addedSkillToRecruitee = false;
					
					for(RecruiteeDto rec : recruitees)
					{
						if(rec.recruiteeId.equals(recruitee.recruiteeId))
						{
							addedSkillToRecruitee = true;
						}
					}
									
					if(!addedSkillToRecruitee)
					{
						completedWithError = true;
					}					
					
				}
				catch(Exception ex)
				{
					completedWithError = true;
					ex.printStackTrace();
				}
				
				return null;
			}
			
			protected void onPostExecute(Void result)
			{
				if(completedWithError)
				{
					dialog.dismiss();
					new CustomDialog(getView().getContext(), "Failed to retrieve data", "No data retrieved");
				}
				else
				{
					startSurveyActivity();
					dialog.dismiss();
					
				}
			}
		}
	}
}
