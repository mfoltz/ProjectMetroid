// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.CastOptionCooldown_Editor
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Behaviours
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct CastOptionCooldown_Editor
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Random;
    private static readonly System.IntPtr NativeFieldInfoPtr_Min;
    private static readonly System.IntPtr NativeFieldInfoPtr_Max;
    [FieldOffset(0)]
    public bool Random;
    [FieldOffset(4)]
    public float Min;
    [FieldOffset(8)]
    public float Max;

    static CastOptionCooldown_Editor()
    {
      Il2CppClassPointerStore<CastOptionCooldown_Editor>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (CastOptionCooldown_Editor));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastOptionCooldown_Editor>.NativeClassPtr);
      CastOptionCooldown_Editor.NativeFieldInfoPtr_Random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionCooldown_Editor>.NativeClassPtr, nameof (Random));
      CastOptionCooldown_Editor.NativeFieldInfoPtr_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionCooldown_Editor>.NativeClassPtr, nameof (Min));
      CastOptionCooldown_Editor.NativeFieldInfoPtr_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionCooldown_Editor>.NativeClassPtr, nameof (Max));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastOptionCooldown_Editor>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
