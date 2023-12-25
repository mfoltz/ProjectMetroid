// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Example_ExplodeCloseBarrel_Event
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Example_ExplodeCloseBarrel_Event
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_Radius;
    [FieldOffset(0)]
    public float3 Position;
    [FieldOffset(12)]
    public float Radius;

    static Example_ExplodeCloseBarrel_Event()
    {
      Il2CppClassPointerStore<Example_ExplodeCloseBarrel_Event>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Example_ExplodeCloseBarrel_Event));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Example_ExplodeCloseBarrel_Event>.NativeClassPtr);
      Example_ExplodeCloseBarrel_Event.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Example_ExplodeCloseBarrel_Event>.NativeClassPtr, nameof (Position));
      Example_ExplodeCloseBarrel_Event.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Example_ExplodeCloseBarrel_Event>.NativeClassPtr, nameof (Radius));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Example_ExplodeCloseBarrel_Event>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
