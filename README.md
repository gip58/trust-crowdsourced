# Analysing trust in a traffic scene with an automated vehicle

This project defines a framework for the analysis of the level of trust in a traffic environment involving an automated vehicle. The jsPsych framework is used to for the frontend. In the description below, it is assumed that the repo is stored in the folder `trust-crowdsourced`. Terminal commands lower assume macOS.

## Setup
Tested with Python 3.9.12. To setup the environment run these two commands in a parent folder of the downloaded repository (replace `/` with `\` and possibly add `--user` if on Windows):
- `pip install -e trust-crowdsourced` will setup the project as a package accessible in the environment.
- `pip install -r trust-crowdsourced/requirements.txt` will install required packages.

### Configuration of project
Configuration of the project needs to be defined in `trust-crowdsourced/config`. Please use the `default.config` file for the required structure of the file. If no custom config file is provided, `default.config` is used. The config file has the following parameters:
* `appen_job`: ID of the appen job.
* `num_stimuli`: number of stimuli in the study.
* `num_stimuli_participant`: subset of stimuli in the study shown to each participant.
* `allowed_min_time`: the cut-off for minimal time of participation for filtering.
* `num_repeat`: number of times each stimulus is repeated.
* `kp_resolution`: bin size in ms in which data is stored.
* `allowed_stimulus_wrong_duration`: if the percentage of videos with abnormal length is above this value, exclude participant from analysis.
* `allowed_mistakes_signs`: number of allowed mistakes in the questions about traffic signs.
* `sign_answers`: answers to the questions on traffic signs.
* `mask_id`: number for masking worker IDs in appen data.
* `files_heroku`: files with data from heroku.
* `file_appen`: file with data from appen.
* `file_cheaters`: CSV file with cheaters for flagging.
* `path_source`: path with source files for the stimuli from the Unity3D project.
* `path_stimuli`: path consisting of all videos included in the survey.
* `mapping_stimuli`: CSV file that contains all data found in the videos.
* `plotly_template`: template used to make graphs in the analysis.

## Preparation of stimuli
The source files of the video stimuli are outputted from Unity to `config.path_source`. To prepare them for the crowdsourced setup `python trust-crowdsourced/preparation/process_videos.py`. Videos will be outputted to `config.path_stimuli`.

## Troubleshooting
### Troubleshooting setup
#### ERROR: trust-crowdsourced is not a valid editable requirement
Check that you are indeed in the parent folder for running command `pip install -e trust-crowdsourced`. This command will not work from inside of the folder containing the repo.

## Figures
### For all participants
[![plot_all_0](figures/AOI_0.html?raw=true)](https://htmlpreview.github.io/?https://github.com/bazilinskyy/trust-crowdsourced/blob/issue-11-lap_people/figures/AOI_0.html)
Plot of AOI Video_0 All Participants
[![plot_all_1](figures/AOI_1.html?raw=true)](https://htmlpreview.github.io/?https://github.com/bazilinskyy/trust-crowdsourced/blob/issue-11-lap_people/figures/AOI_1.html)
Plot of AOI Video_1 All Participants
[![plot_all_2](figures/AOI_2.html?raw=true)](https://htmlpreview.github.io/?https://github.com/bazilinskyy/trust-crowdsourced/blob/issue-11-lap_people/figures/AOI_2.html)
Plot of AOI Video_2 All Participants
[![plot_all_3](figures/AOI_3.html?raw=true)](https://htmlpreview.github.io/?https://github.com/bazilinskyy/trust-crowdsourced/blob/issue-11-lap_people/figures/AOI_3.html)
Plot of AOI Video_3 All Participants
[![plot_all_4](figures/AOI_4.html?raw=true)](https://htmlpreview.github.io/?https://github.com/bazilinskyy/trust-crowdsourced/blob/issue-11-lap_people/figures/AOI_4.html)
Plot of AOI Video_4 All Participants
[![plot_all_5](figures/AOI_5.html?raw=true)](https://htmlpreview.github.io/?https://github.com/bazilinskyy/trust-crowdsourced/blob/issue-11-lap_people/figures/AOI_5.html)
Plot of AOI Video_5 All Participants
[![plot_all_6](figures/AOI_6.html?raw=true)](https://htmlpreview.github.io/?https://github.com/bazilinskyy/trust-crowdsourced/blob/issue-11-lap_people/figures/AOI_6.html)
Plot of AOI Video_6 All Participants
[![plot_all_7](figures/AOI_7.html?raw=true)](https://htmlpreview.github.io/?https://github.com/bazilinskyy/trust-crowdsourced/blob/issue-11-lap_people/figures/AOI_7.html)
Plot of AOI Video_7 All Participants
[![plot_all_8](figures/AOI_8.html?raw=true)](https://htmlpreview.github.io/?https://github.com/bazilinskyy/trust-crowdsourced/blob/issue-11-lap_people/figures/AOI_8.html)
Plot of AOI Video_8 All Participants
[![plot_all_9](figures/AOI_9.html?raw=true)](https://htmlpreview.github.io/?https://github.com/bazilinskyy/trust-crowdsourced/blob/issue-11-lap_people/figures/AOI_9.html)
Plot of AOI Video_9 All Participants
[![plot_all_10](figures/AOI_10.html?raw=true)](https://htmlpreview.github.io/?https://github.com/bazilinskyy/trust-crowdsourced/blob/issue-11-lap_people/figures/AOI_10.html)
Plot of AOI Video_10 All Participants
[![plot_all_11](figures/AOI_11.html?raw=true)](https://htmlpreview.github.io/?https://github.com/bazilinskyy/trust-crowdsourced/blob/issue-11-lap_people/figures/AOI_11.html)
Plot of AOI Video_11 All Participants
[![plot_all_12](figures/AOI_12.html?raw=true)](https://htmlpreview.github.io/?https://github.com/bazilinskyy/trust-crowdsourced/blob/issue-11-lap_people/figures/AOI_12.html)
Plot of AOI Video_12 All Participants
[![plot_all_13](figures/AOI_13.html?raw=true)](https://htmlpreview.github.io/?https://github.com/bazilinskyy/trust-crowdsourced/blob/issue-11-lap_people/figures/AOI_13.html)
Plot of AOI Video_13 All Participants
[![plot_all_14](figures/AOI_14.html?raw=true)](https://htmlpreview.github.io/?https://github.com/bazilinskyy/trust-crowdsourced/blob/issue-11-lap_people/figures/AOI_14.html)
Plot of AOI Video_14 All Participants
[![plot_all_15](figures/AOI_15.html?raw=true)](https://htmlpreview.github.io/?https://github.com/bazilinskyy/trust-crowdsourced/blob/issue-11-lap_people/figures/AOI_15.html)
Plot of AOI Video_15 All Participants
[![plot_all_16](figures/AOI_16.html?raw=true)](https://htmlpreview.github.io/?https://github.com/bazilinskyy/trust-crowdsourced/blob/issue-11-lap_people/figures/AOI_16.html)
Plot of AOI Video_16 All Participants
[![plot_all_17](figures/AOI_17.html?raw=true)](https://htmlpreview.github.io/?https://github.com/bazilinskyy/trust-crowdsourced/blob/issue-11-lap_people/figures/AOI_17.html)
Plot of AOI Video_17 All Participants
[![plot_all_18](figures/AOI_18.html?raw=true)](https://htmlpreview.github.io/?https://github.com/bazilinskyy/trust-crowdsourced/blob/issue-11-lap_people/figures/AOI_18.html)
Plot of AOI Video_18 All Participants
[![plot_all_19](figures/AOI_19.html?raw=true)](https://htmlpreview.github.io/?https://github.com/bazilinskyy/trust-crowdsourced/blob/issue-11-lap_people/figures/AOI_19.html)
Plot of AOI Video_19 All Participants
[![plot_all_20](figures/AOI_20.html?raw=true)](https://htmlpreview.github.io/?https://github.com/bazilinskyy/trust-crowdsourced/blob/issue-11-lap_people/figures/AOI_20.html)
Plot of AOI Video_20 All Participants

### For only lab participants
[![plot_Lab_only_0](figures/Lab_only_AOI_0.html?raw=true)](https://htmlpreview.github.io/?https://github.com/bazilinskyy/trust-crowdsourced/blob/issue-11-lap_people/figures/Lab_only_AOI_0.html)
Plot of AOI Video_0 Lab only Participants
[![plot_Lab_only_1](figures/Lab_only_AOI_1.html?raw=true)](https://htmlpreview.github.io/?https://github.com/bazilinskyy/trust-crowdsourced/blob/issue-11-lap_people/figures/Lab_only_AOI_1.html)
Plot of AOI Video_1 Lab only Participants
[![plot_Lab_only_2](figures/Lab_only_AOI_2.html?raw=true)](https://htmlpreview.github.io/?https://github.com/bazilinskyy/trust-crowdsourced/blob/issue-11-lap_people/figures/Lab_only_AOI_2.html)
Plot of AOI Video_2 Lab only Participants
[![plot_Lab_only_3](figures/Lab_only_AOI_3.html?raw=true)](https://htmlpreview.github.io/?https://github.com/bazilinskyy/trust-crowdsourced/blob/issue-11-lap_people/figures/Lab_only_AOI_3.html)
Plot of AOI Video_3 Lab only Participants
[![plot_Lab_only_4](figures/Lab_only_AOI_4.html?raw=true)](https://htmlpreview.github.io/?https://github.com/bazilinskyy/trust-crowdsourced/blob/issue-11-lap_people/figures/Lab_only_AOI_4.html)
Plot of AOI Video_4 Lab only Participants
[![plot_Lab_only_5](figures/Lab_only_AOI_5.html?raw=true)](https://htmlpreview.github.io/?https://github.com/bazilinskyy/trust-crowdsourced/blob/issue-11-lap_people/figures/Lab_only_AOI_5.html)
Plot of AOI Video_5 Lab only Participants
[![plot_Lab_only_6](figures/Lab_only_AOI_6.html?raw=true)](https://htmlpreview.github.io/?https://github.com/bazilinskyy/trust-crowdsourced/blob/issue-11-lap_people/figures/Lab_only_AOI_6.html)
Plot of AOI Video_6 Lab only Participants
[![plot_Lab_only_7](figures/Lab_only_AOI_7.html?raw=true)](https://htmlpreview.github.io/?https://github.com/bazilinskyy/trust-crowdsourced/blob/issue-11-lap_people/figures/Lab_only_AOI_7.html)
Plot of AOI Video_7 Lab only Participants
[![plot_Lab_only_8](figures/Lab_only_AOI_8.html?raw=true)](https://htmlpreview.github.io/?https://github.com/bazilinskyy/trust-crowdsourced/blob/issue-11-lap_people/figures/Lab_only_AOI_8.html)
Plot of AOI Video_8 Lab only Participants
[![plot_Lab_only_9](figures/Lab_only_AOI_9.html?raw=true)](https://htmlpreview.github.io/?https://github.com/bazilinskyy/trust-crowdsourced/blob/issue-11-lap_people/figures/Lab_only_AOI_9.html)
Plot of AOI Video_9 Lab only Participants
[![plot_Lab_only_10](figures/Lab_only_AOI_10.html?raw=true)](https://htmlpreview.github.io/?https://github.com/bazilinskyy/trust-crowdsourced/blob/issue-11-lap_people/figures/Lab_only_AOI_10.html)
Plot of AOI Video_10 Lab only Participants
[![plot_Lab_only_11](figures/Lab_only_AOI_11.html?raw=true)](https://htmlpreview.github.io/?https://github.com/bazilinskyy/trust-crowdsourced/blob/issue-11-lap_people/figures/Lab_only_AOI_11.html)
Plot of AOI Video_11 Lab only Participants
[![plot_Lab_only_12](figures/Lab_only_AOI_12.html?raw=true)](https://htmlpreview.github.io/?https://github.com/bazilinskyy/trust-crowdsourced/blob/issue-11-lap_people/figures/Lab_only_AOI_12.html)
Plot of AOI Video_12 Lab only Participants
[![plot_Lab_only_13](figures/Lab_only_AOI_13.html?raw=true)](https://htmlpreview.github.io/?https://github.com/bazilinskyy/trust-crowdsourced/blob/issue-11-lap_people/figures/Lab_only_AOI_13.html)
Plot of AOI Video_13 Lab only Participants
[![plot_Lab_only_14](figures/Lab_only_AOI_14.html?raw=true)](https://htmlpreview.github.io/?https://github.com/bazilinskyy/trust-crowdsourced/blob/issue-11-lap_people/figures/Lab_only_AOI_14.html)
Plot of AOI Video_14 Lab only Participants
[![plot_Lab_only_15](figures/Lab_only_AOI_15.html?raw=true)](https://htmlpreview.github.io/?https://github.com/bazilinskyy/trust-crowdsourced/blob/issue-11-lap_people/figures/Lab_only_AOI_15.html)
Plot of AOI Video_15 Lab only Participants
[![plot_Lab_only_16](figures/Lab_only_AOI_16.html?raw=true)](https://htmlpreview.github.io/?https://github.com/bazilinskyy/trust-crowdsourced/blob/issue-11-lap_people/figures/Lab_only_AOI_16.html)
Plot of AOI Video_16 Lab only Participants
[![plot_Lab_only_17](figures/Lab_only_AOI_17.html?raw=true)](https://htmlpreview.github.io/?https://github.com/bazilinskyy/trust-crowdsourced/blob/issue-11-lap_people/figures/Lab_only_AOI_17.html)
Plot of AOI Video_17 Lab only Participants
[![plot_Lab_only_18](figures/Lab_only_AOI_18.html?raw=true)](https://htmlpreview.github.io/?https://github.com/bazilinskyy/trust-crowdsourced/blob/issue-11-lap_people/figures/Lab_only_AOI_18.html)
Plot of AOI Video_18 Lab only Participants
[![plot_Lab_only_19](figures/Lab_only_AOI_19.html?raw=true)](https://htmlpreview.github.io/?https://github.com/bazilinskyy/trust-crowdsourced/blob/issue-11-lap_people/figures/Lab_only_AOI_19.html)
Plot of AOI Video_19 Lab only Participants
[![plot_Lab_only_20](figures/Lab_only_AOI_20.html?raw=true)](https://htmlpreview.github.io/?https://github.com/bazilinskyy/trust-crowdsourced/blob/issue-11-lap_people/figures/Lab_only_AOI_20.html)
Plot of AOI Video_20 Lab only Participants

]

