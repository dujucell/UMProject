package com.example.crowdtranslator;

import java.util.ArrayList;
import java.util.Random;
import java.util.UUID;

import com.Wsdl2Code.WebServices.ServiceMobile.JobDto;
import com.Wsdl2Code.WebServices.ServiceMobile.RecruiteeDto;
import com.Wsdl2Code.WebServices.ServiceMobile.ServiceMobile;
import com.Wsdl2Code.WebServices.ServiceMobile.TaskDto;
import com.julian.controls.CustomDialog;

import android.app.Activity;
import android.app.Fragment;
import android.app.ProgressDialog;
import android.content.Intent;
import android.os.AsyncTask;
import android.os.Bundle;
import android.view.KeyEvent;
import android.view.LayoutInflater;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.View.OnClickListener;
import android.view.View.OnKeyListener;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class SurveyActivity extends Activity {
	
	private static ArrayList<JobDto> jobs;
	private static RecruiteeDto recruitee;
	private static ArrayList<TaskDto> tasks = new ArrayList<TaskDto>();
	private static int numberOfTasks = 5;
	private static int currentTask = 1;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_survey);
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
		recruitee = (RecruiteeDto)receiveBundle.getSerializable("recruitee");
		jobs = (ArrayList<JobDto>)receiveBundle.getSerializable("jobs");
	}
	
	

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.survey, menu);
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
	public static class PlaceholderFragment extends Fragment implements OnClickListener, OnKeyListener{

		public PlaceholderFragment() {
		}

		@Override
		public View onCreateView(LayoutInflater inflater, ViewGroup container,
				Bundle savedInstanceState) {
			View rootView = inflater.inflate(R.layout.fragment_survey,
					container, false);
			
			((Button)rootView.findViewById(R.id.btnNext)).setOnClickListener(this);
			((EditText)rootView.findViewById(R.id.editEnglish)).setOnKeyListener(this);


			return rootView;
		}
		
		public void onStart()
		{
			super.onStart();
			selectQuestion();
		}
		
		protected void startThanksActivity()
		{
			Intent intent = new Intent(this.getActivity(), ThanksActivity.class);
			this.startActivity(intent);
            this.getActivity().finish();
		}
		
		@Override
		public boolean onKey(View v, int keyCode, KeyEvent event) {
			// TODO Auto-generated method stub
			
			if((event.getAction() == KeyEvent.ACTION_DOWN) && (keyCode == KeyEvent.KEYCODE_ENTER))
			{
				saveTranslation();
				return true;
			}
			return false;	
		}

		@Override
		public void onClick(View v) {
			// TODO Auto-generated method stub
			if(v.equals((Button)this.getView().findViewById(R.id.btnNext)))
			{
				saveTranslation();
			}
			
		}
		
		public void saveTranslation()
		{
			String translation = ((TextView)this.getView().findViewById(R.id.editEnglish)).getText().toString();
			
			if(!translation.equals("")){
				TaskDto task = new TaskDto();
				task.taskId = UUID.randomUUID().toString();
				task.jobId = ((TextView)this.getView().findViewById(R.id.txtPortugueseJob)).getTag().toString();
				task.recruiteeId = recruitee.recruiteeId;
				task.taskDescription = translation;
				tasks.add(task);
				
				currentTask++;
				
			}
			
			if(currentTask <= numberOfTasks && jobs.size() > 0)
			{				
				selectQuestion();
			}
			else
			{
				(new TaskConnection()).execute();
			}
		}
		
		public void selectQuestion()
		{
			Random rand = new Random();		
			int index = rand.nextInt(jobs.size());
			TextView txtPortugueseJob = ((TextView)this.getView().findViewById(R.id.txtPortugueseJob));
			JobDto job = jobs.get(index);
			txtPortugueseJob.setText(job.jobDescription);
			txtPortugueseJob.setTag(job.jobId);
			jobs.remove(index);
			((EditText)this.getView().findViewById(R.id.editEnglish)).setText("");
			
		}
		
		protected class TaskConnection extends AsyncTask<Void, Void, Void>
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
					
					for(TaskDto task : tasks)
					{
						svc.insertTask(task.taskId, task.jobId, task.recruiteeId, task.taskDescription);
						
						TaskDto sel_task = svc.selectTaskById(task.taskId);
						if(sel_task == null)
						{
							completedWithError = true;
						}
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
					new CustomDialog(getView().getContext(), "Failed to send data", "No data sent");
				}
				else
				{
					startThanksActivity();
					dialog.dismiss();
					
				}
			}
		}

		
	}
}
