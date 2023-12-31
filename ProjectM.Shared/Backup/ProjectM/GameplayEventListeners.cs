// Decompiled with JetBrains decompiler
// Type: ProjectM.GameplayEventListeners
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct GameplayEventListeners
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EventIdIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_EventIndexOfType;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConditionBlob;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameplayEventType;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameplayEventId;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameplayEventTypeEnum_GameplayEventId_Int32_Int32_BlobAssetReference_1_ConditionBlob_0;
    [FieldOffset(0)]
    public int EventIdIndex;
    [FieldOffset(4)]
    public int EventIndexOfType;
    [FieldOffset(8)]
    public BlobAssetReference<ProjectM.Shared.ConditionBlob> ConditionBlob;
    [FieldOffset(16)]
    public GameplayEventTypeEnum GameplayEventType;
    [FieldOffset(20)]
    public GameplayEventId GameplayEventId;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 740819, RefRangeEnd = 740820, XrefRangeStart = 740819, XrefRangeEnd = 740819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GameplayEventListeners(
      GameplayEventTypeEnum gameplayEventType,
      GameplayEventId gameplayEventId,
      int eventIdIndex,
      int eventIndexOfType,
      BlobAssetReference<ProjectM.Shared.ConditionBlob> conditionBlob)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &gameplayEventType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &gameplayEventId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &eventIdIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &eventIndexOfType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &conditionBlob;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayEventListeners.NativeMethodInfoPtr__ctor_Public_Void_GameplayEventTypeEnum_GameplayEventId_Int32_Int32_BlobAssetReference_1_ConditionBlob_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GameplayEventListeners()
    {
      Il2CppClassPointerStore<GameplayEventListeners>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (GameplayEventListeners));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayEventListeners>.NativeClassPtr);
      GameplayEventListeners.NativeFieldInfoPtr_EventIdIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayEventListeners>.NativeClassPtr, nameof (EventIdIndex));
      GameplayEventListeners.NativeFieldInfoPtr_EventIndexOfType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayEventListeners>.NativeClassPtr, nameof (EventIndexOfType));
      GameplayEventListeners.NativeFieldInfoPtr_ConditionBlob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayEventListeners>.NativeClassPtr, nameof (ConditionBlob));
      GameplayEventListeners.NativeFieldInfoPtr_GameplayEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayEventListeners>.NativeClassPtr, nameof (GameplayEventType));
      GameplayEventListeners.NativeFieldInfoPtr_GameplayEventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayEventListeners>.NativeClassPtr, nameof (GameplayEventId));
      GameplayEventListeners.NativeMethodInfoPtr__ctor_Public_Void_GameplayEventTypeEnum_GameplayEventId_Int32_Int32_BlobAssetReference_1_ConditionBlob_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayEventListeners>.NativeClassPtr, 100665390);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameplayEventListeners>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
