## Warning!!
Set "capi" first!

```csharp
CursorAPI capi = new CursorAPI();
```

-> "capi" it can be by the name you want, it's your choice

Examples:
---

Mouse Speed

  ```csharp
  int speed = capi.GetMouseSpeed();
  label1.Text = $"Mouse speed: {speed}";
  ```

  ```csharp
  capi.SetMouseSpeed(1); //min
  capi.SetMouseSpeed(20); //max
  ```
---

Mouse Click Lock

  ```csharp
  if(capi.GetMouseClickLock() == 1)
  {
       label1.Text = "Click Lock: Active!";
  }
  else
  {
       label1.Text = "Click Lock: No Active =(";
  }
  ```

  ```csharp
  capi.SetMouseClickLock(1); // active
  capi.SetMouseClickLock(0); // no active
  ```
---

Mouse Vanish

  ```csharp
  if(capi.GetMouseVanish() == 1)
  {
       label1.Text = "Mouse Vanish: Active!";
  }
  else
  {
       label1.Text = "Mouse Vanish: No Active =(";
  }
  ```
  
  ```csharp
  capi.SetMouseVanish(1); // active
  capi.SetMouseVanish(0); // no active
  ```
---

Mouse Shadow

  ```csharp
  if(capi.GetMouseShadow() == 1)
  {
       label1.Text = "Mouse Shadow: Active!";
  }
  else
  {
       label1.Text = "Mouse Shadow: No Active =(";
  }
  ```
  
  ```csharp
  capi.SetMouseShadow(1); // active
  capi.SetMouseShadow(0); // no active
  ```
---

Mouse Ctrl Show

  ```csharp
  if(capi.GetMouseCtrlShow() == 1)
  {
       label1.Text = "Ctrl Show: Active!";
  }
  else
  {
       label1.Text = "Ctrl Show: No Active =(";
  }
  ```
  
  ```csharp
  capi.SetMouseCtrlShow(1); // active
  capi.SetMouseCtrlShow(0); // no active
  ```
