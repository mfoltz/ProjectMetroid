// Decompiled with JetBrains decompiler
// Type: ProjectM.GenerateAggroOnGameplayEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct GenerateAggroOnGameplayEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_From;
    private static readonly System.IntPtr NativeFieldInfoPtr_Towards;
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    [FieldOffset(0)]
    public AggroGameplayEventWho From;
    [FieldOffset(4)]
    public AggroGameplayEventWho Towards;
    [FieldOffset(8)]
    public float Value;

    static GenerateAggroOnGameplayEvent()
    {
      Il2CppClassPointerStore<GenerateAggroOnGameplayEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (GenerateAggroOnGameplayEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenerateAggroOnGameplayEvent>.NativeClassPtr);
      GenerateAggroOnGameplayEvent.NativeFieldInfoPtr_From = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateAggroOnGameplayEvent>.NativeClassPtr, nameof (From));
      GenerateAggroOnGameplayEvent.NativeFieldInfoPtr_Towards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateAggroOnGameplayEvent>.NativeClassPtr, nameof (Towards));
      GenerateAggroOnGameplayEvent.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateAggroOnGameplayEvent>.NativeClassPtr, nameof (Value));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GenerateAggroOnGameplayEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
