// Decompiled with JetBrains decompiler
// Type: ProjectM.CreateGameplayEventOnInventoryChange
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CreateGameplayEventOnInventoryChange
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EventId;
    private static readonly System.IntPtr NativeFieldInfoPtr_TriggerMultipleTimes;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChangeType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Initialized;
    private static readonly System.IntPtr NativeFieldInfoPtr_Hash;
    private static readonly System.IntPtr NativeFieldInfoPtr_Triggered;
    [FieldOffset(0)]
    public GameplayEventId EventId;
    [FieldOffset(8)]
    public bool TriggerMultipleTimes;
    [FieldOffset(12)]
    public InventoryChangeType ChangeType;
    [FieldOffset(16)]
    public bool Initialized;
    [FieldOffset(24)]
    public long Hash;
    [FieldOffset(32)]
    public bool Triggered;

    static CreateGameplayEventOnInventoryChange()
    {
      Il2CppClassPointerStore<CreateGameplayEventOnInventoryChange>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CreateGameplayEventOnInventoryChange));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateGameplayEventOnInventoryChange>.NativeClassPtr);
      CreateGameplayEventOnInventoryChange.NativeFieldInfoPtr_EventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventOnInventoryChange>.NativeClassPtr, nameof (EventId));
      CreateGameplayEventOnInventoryChange.NativeFieldInfoPtr_TriggerMultipleTimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventOnInventoryChange>.NativeClassPtr, nameof (TriggerMultipleTimes));
      CreateGameplayEventOnInventoryChange.NativeFieldInfoPtr_ChangeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventOnInventoryChange>.NativeClassPtr, nameof (ChangeType));
      CreateGameplayEventOnInventoryChange.NativeFieldInfoPtr_Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventOnInventoryChange>.NativeClassPtr, nameof (Initialized));
      CreateGameplayEventOnInventoryChange.NativeFieldInfoPtr_Hash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventOnInventoryChange>.NativeClassPtr, nameof (Hash));
      CreateGameplayEventOnInventoryChange.NativeFieldInfoPtr_Triggered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventOnInventoryChange>.NativeClassPtr, nameof (Triggered));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CreateGameplayEventOnInventoryChange>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
