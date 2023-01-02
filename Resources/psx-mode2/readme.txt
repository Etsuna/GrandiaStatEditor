PSX-MODE2 v20110910 - (c) CUE
-----------------------------

Simple tool to replace files in a PSX CD image:

- update the file
- update the file folder
- update the path tables
- update all file/folder LBAs
- update all EDC/ECC changed

-----------------------------

Syntax: psx-mode2 image_name \path\to\original_file new_file [-n]

* 'image_name' is the valid MODE2/2352 CD image (BIN/ISO/MDF/IMG)
* 'original_file' must include the full path and begin with a '\'
* 'filename' must be a MODE2/FORM1 file
* the CD image file is reconstructed if necessary
* the EDC/ECC of the modified sectors are recalculated

* '-n' do not use EDC in the modified MODE2/FORM2 sectors
* use either '\' or '/' they are interchangable

* NO replacement of CDA files (representations of audio tracks)
* NO modification of the CUE sheet if it already exists
* NO guarantee of result when processing audio/sound files in FORM2
* NO guarantee of result when dealing with files that use FORM1 & FORM2
* NO hidden LBAs are recalculated

----------------------
PSX-MODE2-EN v20180702
----------------------
English translation by @gingerbeardman
