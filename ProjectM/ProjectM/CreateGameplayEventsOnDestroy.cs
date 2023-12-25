// Decompiled with JetBrains decompiler
// Type: ProjectM.CreateGameplayEventsOnDestroy
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CreateGameplayEventsOnDestroy
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EventId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpecificDestroyReason;
    private static readonly System.IntPtr NativeFieldInfoPtr_DestroyReason;
    [FieldOffset(0)]
    public GameplayEventId EventId;
    [FieldOffset(8)]
    public GameplayEventTarget Target;
    [FieldOffset(12)]
    public bool SpecificDestroyReason;
    [FieldOffset(13)]
    public DestroyReason DestroyReason;

    static CreateGameplayEventsOnDestroy()
    {
      Il2CppClassPointerStore<CreateGameplayEventsOnDestroy>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CreateGameplayEventsOnDestroy));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateGameplayEventsOnDestroy>.NativeClassPtr);
      CreateGameplayEventsOnDestroy.NativeFieldInfoPtr_EventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDestroy>.NativeClassPtr, nameof (EventId));
      CreateGameplayEventsOnDestroy.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDestroy>.NativeClassPtr, nameof (Target));
      CreateGameplayEventsOnDestroy.NativeFieldInfoPtr_SpecificDestroyReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDestroy>.NativeClassPtr, nameof (SpecificDestroyReason));
      CreateGameplayEventsOnDestroy.NativeFieldInfoPtr_DestroyReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDestroy>.NativeClassPtr, nameof (DestroyReason));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CreateGameplayEventsOnDestroy>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
