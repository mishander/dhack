mkdir -p data/train
rm -rf data/train/*

#Update the value of fontlist according to training fonts name
#Update the value of lang according to training language
sh data/tesstrain.sh \
  --fonts_dir data/fonts\
  --fontlist 'Arial' \
  'Times New Roman' \
  --lang ukr  \
  --linedata_only   \
  --langdata_dir data/langdata_lstm \
  --tessdata_dir data/tessdata \
  --save_box_tiff \
  --maxpages 25\
  --overwrite \
  --training_text data/langdata_lstm/ukr/ukr.training_text \
  --wordlist data/langdata_lstm/ukr/ukr.wordlist \
  --output_dir data/train 
  
  mkdir -p output
  rm -rf output/*
  
  #Update eng.traineddata and eng.lstm according to training language to lang.traineddata and lang.lstm
  combine_tessdata -e data/tessdata/ukr.traineddata data/train/ukr.lstm
  
  
  lstmtraining --model_output output/Arial \
  --continue_from data/train/ukr.lstm \
  --traineddata data/train/ukr/ukr.traineddata \
  --old_traineddata data/tessdata/ukr.traineddata \
  --train_listfile data/train/ukr.training_files.txt \
  --max_iterations 3600
  
  #Update eng.traineddata according to training language
  #Update impact_checkpoint and Impact.traineddata according to training font name
  lstmtraining --stop_training \
  --continue_from output/Arial_checkpoint \
  --traineddata data/train/ukr/ukr.traineddata \
  --model_output output/ukr.traineddata