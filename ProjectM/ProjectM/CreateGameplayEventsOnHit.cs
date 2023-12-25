// Decompiled with JetBrains decompiler
// Type: ProjectM.CreateGameplayEventsOnHit
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CreateGameplayEventsOnHit
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EventId;
    private static readonly System.IntPtr NativeFieldInfoPtr_HitGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_Condition;
    [FieldOffset(0)]
    public GameplayEventId EventId;
    [FieldOffset(8)]
    public HitGroup HitGroup;
    [FieldOffset(16)]
    public BlobAssetReference<ConditionBlob> Condition;

    static CreateGameplayEventsOnHit()
    {
      Il2CppClassPointerStore<CreateGameplayEventsOnHit>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CreateGameplayEventsOnHit));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateGameplayEventsOnHit>.NativeClassPtr);
      CreateGameplayEventsOnHit.NativeFieldInfoPtr_EventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnHit>.NativeClassPtr, nameof (EventId));
      CreateGameplayEventsOnHit.NativeFieldInfoPtr_HitGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnHit>.NativeClassPtr, nameof (HitGroup));
      CreateGameplayEventsOnHit.NativeFieldInfoPtr_Condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnHit>.NativeClassPtr, nameof (Condition));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CreateGameplayEventsOnHit>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
