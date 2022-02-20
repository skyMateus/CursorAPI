# How to Use

wiki of functions ..
---
- How do I manage the speed of my mouse?
  - Get Mouse Speed:
    ```csharp
    int speed = GetMouseSpeed();
    label1.Text = $"Mouse speed: {speed}";
    ```
  - Set Mouse Speed:
    ```csharp
    SetMouseSpeed(1); //min
    SetMouseSpeed(20); //max
    ```
---
- How do I manage my click lock?
  - Check if it's active:
    ```csharp
    if(GetMouseClickLock())
    {
         label1.Text = "Click Lock: Active!";
    }
    else
    {
         label1.Text = "Click Lock: No Active =(";
    }
    ```
