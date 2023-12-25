// Decompiled with JetBrains decompiler
// Type: ProjectM.DestroyOnGameplayEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DestroyOnGameplayEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Who;
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_DestroyReason;
    private static readonly System.IntPtr NativeFieldInfoPtr_SetTranslationToEventTranslation;
    [FieldOffset(0)]
    public DestroyOnGameplayEventWho Who;
    [FieldOffset(4)]
    public DestroyOnGameplayEventType Type;
    [FieldOffset(8)]
    public DestroyReason DestroyReason;
    [FieldOffset(9)]
    public bool SetTranslationToEventTranslation;

    static DestroyOnGameplayEvent()
    {
      Il2CppClassPointerStore<DestroyOnGameplayEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DestroyOnGameplayEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyOnGameplayEvent>.NativeClassPtr);
      DestroyOnGameplayEvent.NativeFieldInfoPtr_Who = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyOnGameplayEvent>.NativeClassPtr, nameof (Who));
      DestroyOnGameplayEvent.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyOnGameplayEvent>.NativeClassPtr, nameof (Type));
      DestroyOnGameplayEvent.NativeFieldInfoPtr_DestroyReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyOnGameplayEvent>.NativeClassPtr, nameof (DestroyReason));
      DestroyOnGameplayEvent.NativeFieldInfoPtr_SetTranslationToEventTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyOnGameplayEvent>.NativeClassPtr, nameof (SetTranslationToEventTranslation));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DestroyOnGameplayEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
