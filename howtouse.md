Examples:
---

Mouse Speed

  ```csharp
  int speed = GetMouseSpeed();
  label1.Text = $"Mouse speed: {speed}";
  ```

  ```csharp
  SetMouseSpeed(1); //min
  SetMouseSpeed(20); //max
  ```
---

Mouse Click Lock

  ```csharp
  if(GetMouseClickLock() == 1)
  {
       label1.Text = "Click Lock: Active!";
  }
  else
  {
       label1.Text = "Click Lock: No Active =(";
  }
  ```

  ```csharp
  SetMouseClickLock(1); // active
  SetMouseClickLock(0); // no active
  ```
---

Mouse Vanish

  ```csharp
  if(GetMouseVanish() == 1)
  {
       label1.Text = "Mouse Vanish: Active!";
  }
  else
  {
       label1.Text = "Mouse Vanish: No Active =(";
  }
  ```
  
  ```csharp
  SetMouseVanish(1); // active
  SetMouseVanish(0); // no active
  ```
---

Mouse Shadow

  ```csharp
  if(GetMouseShadow() == 1)
  {
       label1.Text = "Mouse Shadow: Active!";
  }
  else
  {
       label1.Text = "Mouse Shadow: No Active =(";
  }
  ```
  
  ```csharp
  SetMouseShadow(1); // active
  SetMouseShadow(0); // no active
  ```
---

Mouse Ctrl Show

  ```csharp
  if(GetMouseCtrlShow() == 1)
  {
       label1.Text = "Ctrl Show: Active!";
  }
  else
  {
       label1.Text = "Ctrl Show: No Active =(";
  }
  ```
  
  ```csharp
  SetMouseCtrlShow(1); // active
  SetMouseCtrlShow(0); // no active
  ```
