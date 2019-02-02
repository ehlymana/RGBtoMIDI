# RGBtoMIDI

A C# *Windows Forms* application for the conversion of RGB images to MIDI files.

## How the App Works

First, an RGB image is chosen for the conversion.

Afterwards, different colors that the image contains are converted into one of the 128 possible different musical notes (ranging from C0 to  B9, or from 16.35 Hz to 15,804.26 Hz).

The notes are then put together into a playback **.mid** file using the MIDI protocol.

## The Code

The code consists of the following parts:

1. *MIDI* - contains the code necessary for the creation of the final audio playback file;

2. *RGBtoMIDIApp* - contains the *Windows Forms* application which allows the user to do the following actions:

	- Choose the image for the conversion;
	- Convert the image to sound;
	- Choose the *.mid* file for playback;
	- Play the chosen sound.

© Belma Muftić, Nejra Kulović & Ehlimana Krupalija, 2019.

*University of Sarajevo*

*Faculty of Electrical Engineering*

*Department of Computing and Informatics*