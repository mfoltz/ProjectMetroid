// Decompiled with JetBrains decompiler
// Type: ProjectM.CreateGameplayEventOnDamageTaken
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
  public struct CreateGameplayEventOnDamageTaken
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EventId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Condition;
    private static readonly System.IntPtr NativeFieldInfoPtr_Source;
    private static readonly System.IntPtr NativeFieldInfoPtr_IncludeDoTs;
    [FieldOffset(0)]
    public GameplayEventId EventId;
    [FieldOffset(8)]
    public BlobAssetReference<ConditionBlob> Condition;
    [FieldOffset(16)]
    public DamageTakenTarget Source;
    [FieldOffset(20)]
    public bool IncludeDoTs;

    static CreateGameplayEventOnDamageTaken()
    {
      Il2CppClassPointerStore<CreateGameplayEventOnDamageTaken>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CreateGameplayEventOnDamageTaken));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateGameplayEventOnDamageTaken>.NativeClassPtr);
      CreateGameplayEventOnDamageTaken.NativeFieldInfoPtr_EventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventOnDamageTaken>.NativeClassPtr, nameof (EventId));
      CreateGameplayEventOnDamageTaken.NativeFieldInfoPtr_Condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventOnDamageTaken>.NativeClassPtr, nameof (Condition));
      CreateGameplayEventOnDamageTaken.NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventOnDamageTaken>.NativeClassPtr, nameof (Source));
      CreateGameplayEventOnDamageTaken.NativeFieldInfoPtr_IncludeDoTs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventOnDamageTaken>.NativeClassPtr, nameof (IncludeDoTs));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CreateGameplayEventOnDamageTaken>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
