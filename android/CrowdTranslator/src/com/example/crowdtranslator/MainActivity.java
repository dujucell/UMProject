package com.example.crowdtranslator;

import java.util.UUID;

import com.Wsdl2Code.WebServices.ServiceMobile.RecruiteeDto;
import com.Wsdl2Code.WebServices.ServiceMobile.ServiceMobile;
import com.Wsdl2Code.WebServices.ServiceMobile.VectorJobDto;
import com.Wsdl2Code.WebServices.ServiceMobile.VectorSkillDto1;
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
import android.widget.Button;

public class MainActivity extends Activity {
	private static VectorSkillDto1 skills;
	private static VectorJobDto jobs;
	private static RecruiteeDto recruitee;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
		if (savedInstanceState == null) {
			getFragmentManager().beginTransaction()
					.add(R.id.container, new PlaceholderFragment()).commit();
		}
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.main, menu);
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
	public static class PlaceholderFragment extends Fragment implements OnClickListener {

		public PlaceholderFragment() {
		}

		@Override
		public View onCreateView(LayoutInflater inflater, ViewGroup container,
				Bundle savedInstanceState) {
			View rootView = inflater.inflate(R.layout.fragment_main, container,
					false);
			
			((Button)rootView.findViewById(R.id.btnStart)).setOnClickListener(this);
			
			return rootView;
		}
		
		protected void startLevelActivity()
		{
			Intent intent = new Intent(this.getActivity(), LevelActivity.class);
	        Bundle sendBundle = new Bundle();
        	sendBundle.putSerializable("skills", skills);
        	sendBundle.putSerializable("jobs", jobs);
        	sendBundle.putSerializable("recruitee", recruitee);
        	intent.putExtras(sendBundle);
            this.startActivity(intent);
            this.getActivity().finish();

		}
		
		public void onClick(View v) 
		{			
			if(v.equals((Button)this.getView().findViewById(R.id.btnStart)))
			{
				(new DataRetriever()).execute();
			}
	
		}
		
		protected class DataRetriever extends AsyncTask<Void, Void, Void>
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
					String rid = UUID.randomUUID().toString();
					svc.insertRecruitee(rid, "");
					
					recruitee = svc.selectRecruiteeById(rid);
					if(recruitee != null)
					{						
						skills = svc.selectAllSkillRecruitee();
						jobs = svc.selectAllJob();
					}
					else
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
					startLevelActivity();
					dialog.dismiss();
				}
			}
		}
	
	}
}
