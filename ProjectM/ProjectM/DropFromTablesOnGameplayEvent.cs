// Decompiled with JetBrains decompiler
// Type: ProjectM.DropFromTablesOnGameplayEvent
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
  public struct DropFromTablesOnGameplayEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DropTrigger;
    private static readonly System.IntPtr NativeFieldInfoPtr_DropAt;
    [FieldOffset(0)]
    public DropTriggerType DropTrigger;
    [FieldOffset(4)]
    public DropAtLocation DropAt;

    static DropFromTablesOnGameplayEvent()
    {
      Il2CppClassPointerStore<DropFromTablesOnGameplayEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DropFromTablesOnGameplayEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropFromTablesOnGameplayEvent>.NativeClassPtr);
      DropFromTablesOnGameplayEvent.NativeFieldInfoPtr_DropTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropFromTablesOnGameplayEvent>.NativeClassPtr, nameof (DropTrigger));
      DropFromTablesOnGameplayEvent.NativeFieldInfoPtr_DropAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropFromTablesOnGameplayEvent>.NativeClassPtr, nameof (DropAt));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DropFromTablesOnGameplayEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
