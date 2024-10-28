# Augmented Reality Sports Project

## Overview
This project utilizes Augmented Reality (AR) technology to enhance the experience of indoor sports such as badminton and tennis. By projecting virtual court lines onto the physical surface, players can visualize game boundaries more effectively.

## Features
- **Real-time Visualization**: Displays accurate court lines in real-time as players move around the court.
- **Marker Detection**: Scans a specially placed marker on the ground to align the virtual elements correctly.
- **User-Friendly Interface**: Easy-to-use application designed for both casual players and professional athletes.

## Supported Sports
- **Badminton**
- **Tennis**
- **Other Indoor Sports**: Future updates may include support for additional sports.

![image](https://github.com/user-attachments/assets/8f2c029b-ba03-488d-b16e-3d1de3564080)


## Technical Implementation

The **Augmented Reality Sports Project** was developed using **Unity** with the **Vuforia SDK** for marker-based AR. Below are the technical details on how the project was implemented.

### Development Environment

- **Unity Version**: 2121.3.18f1
- **Vuforia SDK Version**: 10.20.3
- **Programming Language**: C#

### Implementation Steps

1. **Setup Unity and Vuforia**:
   - Installed Unity and imported the Vuforia SDK package into the project.
   - Configured the project settings to enable AR capabilities.

2. **Marker Creation and Storage**:
   - Designed a custom marker (e.g., a printed image with a unique pattern) using graphic design software.
   - Uploaded the marker to the **Vuforia Developer Portal**, where it is stored in a database. This database associates the marker image with a unique identifier for recognition.

3. **Importing the Marker Database into Unity**:
   - After creating the marker in the Vuforia Developer Portal, downloaded the associated database.
   - In Unity, imported the downloaded database package. This package includes the marker details and configurations necessary for recognition.
   - Enabled the database in the Vuforia configuration settings within Unity.

4. **Scene Setup**:
   - Created a new scene in Unity and added a Vuforia AR Camera.
   - Integrated the image target component to recognize the printed marker on the court.

5. **Court Line Visualization**:
   - Created 3D models of the court lines using Unity's built-in primitives (e.g., planes or lines).
   - Programmatically defined the position and scale of the court lines to match real-world dimensions.

6. **Marker Detection Logic**:
   - Implemented scripts to manage marker detection:
     - On detection, the app retrieves the marker's position and orientation.
     - The corresponding court lines are instantiated and aligned based on the marker's coordinates.

7. **User Interface Development**:
   - Designed a user-friendly interface using Unity's UI toolkit:
     - Buttons for selecting outer and inner lines, and enlarging the court visualization.
     - Added feedback mechanisms (e.g., sound or visual cues) to enhance user interaction.

8. **Testing and Optimization**:
   - Conducted extensive testing in various indoor environments to ensure reliable marker detection and accurate overlay of court lines.
   - Optimized performance to maintain a smooth frame rate, ensuring a responsive user experience.

### Usage Instructions

1. **Marker Placement**: Print and lay the marker flat on the playing surface.
2. **Open the App and Scan**: Launch the app, grant camera access, and scan for the marker.
3. **Select Outlines**: Use the UI to display the outer boundaries of the court.
4. **Select Court**: Toggle the display of inner lines to improve court layout understanding.
5. **Adjust Visualization**: Use the enlarge button to fit the court to your specific needs.

![image](https://github.com/user-attachments/assets/d9901261-30ad-42fe-b26d-395e8a2691a8)


### Future Improvements

- **Additional Sports Support**: Implement features for more sports like squash and racquetball.
- **Enhanced Graphics**: Improve visual fidelity with better textures and effects for the court lines.
- **User Feedback Integration**: Regular updates based on user suggestions for improved functionality and experience.

By utilizing the power of AR and an intuitive interface, the Augmented Reality Sports Project aims to transform indoor sports training and gameplay, making it more engaging and visually informative for players of all levels.
