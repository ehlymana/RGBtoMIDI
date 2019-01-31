# RGBtoMIDI

A C# WinForms app for the conversion of RGB images to MIDI files.

## How the App Works

First, an RGB image is chosen for the conversion.

Afterwards, different colors that the image contains are converted into one of the 128 possible different musical notes (ranging from C͵͵͵ to  b′′′′′′, or from 13,75 Hz to 14.080 Hz).

The notes are then put together into a playback **.mid** file using the MIDI protocol.

## The Code

The code consists of the following parts:

1. *MIDILibrary* - contains the code necessary for the creation of the final audio playback file;

© Belma Muftić, Nejra Kulović & Ehlimana Krupalija, 2019.

*University of Sarajevo*

*Faculty of Electrical Engineering*

*Department of Computing and Informatics*