mkdir -p train
rm -rf train/*

#Update the value of fontlist according to training fonts name
#Update the value of lang according to training language
sh tesstrain.sh \
  --fonts_dir fonts\
  --fontlist 'Arial' \
  --lang ukr  \
  --linedata_only   \
  --langdata_dir langdata_lstm \
  --tessdata_dir tessdata \
  --save_box_tiff \
  --maxpages 10\
  --overwrite \
  --training_text langdata_lstm\\ukr\\ukr.training_text \
  --wordlist langdata_lstm\\ukr\\ukr.wordlist \
  --output_dir train 
  
  mkdir -p output
  rm -rf output/*
  
  #Update eng.traineddata and eng.lstm according to training language to lang.traineddata and lang.lstm
  combine_tessdata -e tessdata/ukr.traineddata train/ukr.lstm
  
  
  lstmtraining --model_output output/Arial \
  --continue_from train/ukr.lstm \
  --traineddata train\\ukr\\ukr.traineddata \
  --old_traineddata tessdata\\ukr.traineddata \
  --train_listfile train/ukr.training_files.txt \
  --max_iterations 3600
  
  #Update eng.traineddata according to training language
  #Update impact_checkpoint and Impact.traineddata according to training font name
  lstmtraining --stop_training \
  --continue_from output/Arial_checkpoint \
  --traineddata train\\ukr\\ukr.traineddata \
  --model_output output/ukr.traineddata