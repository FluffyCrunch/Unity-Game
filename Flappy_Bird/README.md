# Flappy Bird - Unity Game

A classic Flappy Bird game implementation built with Unity Engine. Navigate through pipes, avoid obstacles, and try to achieve the highest score possible!

## 🎮 Game Features

- **Classic Flappy Bird Gameplay**: Control a bird that flies through gaps between pipes
- **Score System**: Earn points by successfully passing through pipes
- **Multiple Input Methods**: Supports keyboard (Space), mouse clicks, and touch controls
- **Animated Bird**: Sprite animation for smooth bird movement
- **Parallax Background**: Scrolling background effect for enhanced visual appeal
- **Game Over & Restart**: Clean game over screen with restart functionality

## 🛠️ Technical Details

- **Unity Version**: 2021.3.16f1
- **Target Frame Rate**: 60 FPS
- **Platform**: Cross-platform (supports desktop and mobile)

## 📁 Project Structure

```
Assets/
├── Scripts/
│   ├── GameManager.cs      # Manages game state, score, and UI
│   ├── Player.cs           # Bird movement, physics, and input handling
│   ├── Pipes.cs            # Pipe obstacle behavior and movement
│   ├── Spawner.cs          # Pipe spawning system
│   └── Parallax.cs         # Background parallax scrolling
├── Sprites/                # Game sprites (bird, pipes, background, UI)
├── Prefabs/                # Prefabricated game objects
├── Materials/              # Material assets
├── Fonts/                  # Custom fonts
└── Scenes/
    └── FlappyBird.unity    # Main game scene
```

## 🎯 How to Play

1. **Start the Game**: Click the play button to begin
2. **Control the Bird**: 
   - Press **Space** key
   - Click **Left Mouse Button**
   - **Tap** on mobile devices
3. **Objective**: Navigate through the gaps between pipes without colliding
4. **Scoring**: Each pipe you pass through increases your score by 1
5. **Game Over**: Colliding with a pipe or the ground ends the game

## 🚀 Getting Started

### Prerequisites

- Unity Editor 2021.3.16f1 or compatible version
- Basic knowledge of Unity Editor

### Installation

1. Clone this repository:
   ```bash
   git clone https://github.com/Fluffycrunch/Unity-Game.git
   cd Flappy_Bird
   ```

2. Open the project in Unity:
   - Launch Unity Hub
   - Click "Add" and select the `Flappy_Bird` folder
   - Open the project (Unity will import assets automatically)

3. Open the main scene:
   - Navigate to `Assets/Scenes/FlappyBird.unity`
   - Press Play to test the game

## 📝 Scripts Overview

### GameManager.cs
- Manages game state (play, pause, game over)
- Handles score tracking and UI updates
- Controls player activation/deactivation

### Player.cs
- Implements bird physics with gravity
- Handles multiple input methods (keyboard, mouse, touch)
- Manages sprite animation
- Detects collisions with obstacles and scoring zones

### Pipes.cs
- Moves pipes from right to left
- Automatically destroys pipes when off-screen

### Spawner.cs
- Spawns pipe obstacles at regular intervals
- Randomizes pipe height for varied gameplay

### Parallax.cs
- Creates scrolling background effect
- Enhances visual depth

## 🎨 Customization

You can customize various aspects of the game:

- **Bird Physics**: Adjust `gravity` and `strength` in `Player.cs`
- **Pipe Speed**: Modify `speed` in `Pipes.cs`
- **Spawn Rate**: Change `spawnRate` in `Spawner.cs`
- **Pipe Height Range**: Adjust `minHeight` and `maxHeight` in `Spawner.cs`
- **Frame Rate**: Modify `Application.targetFrameRate` in `GameManager.cs`

## 📄 License

This project is open source and available for educational purposes.

## 🤝 Contributing

Feel free to fork this project and submit pull requests for any improvements!

## 👤 Author

Created by FluffyCrunch

## 📧 Contact

For questions or suggestions, please open an issue on the repository.

---

**Enjoy playing Flappy Bird!** 🐦

