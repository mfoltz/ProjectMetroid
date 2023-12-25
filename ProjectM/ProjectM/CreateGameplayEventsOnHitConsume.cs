// Decompiled with JetBrains decompiler
// Type: ProjectM.CreateGameplayEventsOnHitConsume
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CreateGameplayEventsOnHitConsume
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EventId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Filter;
    private static readonly System.IntPtr NativeFieldInfoPtr_DestroySpell;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxAngleDiff;
    [FieldOffset(0)]
    public GameplayEventId EventId;
    [FieldOffset(8)]
    public HitConsumeFilter Filter;
    [FieldOffset(16)]
    public bool DestroySpell;
    [FieldOffset(20)]
    public float MaxAngleDiff;

    static CreateGameplayEventsOnHitConsume()
    {
      Il2CppClassPointerStore<CreateGameplayEventsOnHitConsume>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CreateGameplayEventsOnHitConsume));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateGameplayEventsOnHitConsume>.NativeClassPtr);
      CreateGameplayEventsOnHitConsume.NativeFieldInfoPtr_EventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnHitConsume>.NativeClassPtr, nameof (EventId));
      CreateGameplayEventsOnHitConsume.NativeFieldInfoPtr_Filter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnHitConsume>.NativeClassPtr, nameof (Filter));
      CreateGameplayEventsOnHitConsume.NativeFieldInfoPtr_DestroySpell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnHitConsume>.NativeClassPtr, nameof (DestroySpell));
      CreateGameplayEventsOnHitConsume.NativeFieldInfoPtr_MaxAngleDiff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnHitConsume>.NativeClassPtr, nameof (MaxAngleDiff));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CreateGameplayEventsOnHitConsume>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
