// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.OffsetAndScale
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  [StructLayout(LayoutKind.Explicit)]
  public struct OffsetAndScale
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Offset;
    private static readonly System.IntPtr NativeFieldInfoPtr_Scale;
    [FieldOffset(0)]
    public Vector2 Offset;
    [FieldOffset(8)]
    public float Scale;

    static OffsetAndScale()
    {
      Il2CppClassPointerStore<OffsetAndScale>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (OffsetAndScale));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OffsetAndScale>.NativeClassPtr);
      OffsetAndScale.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffsetAndScale>.NativeClassPtr, nameof (Offset));
      OffsetAndScale.NativeFieldInfoPtr_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffsetAndScale>.NativeClassPtr, nameof (Scale));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OffsetAndScale>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
