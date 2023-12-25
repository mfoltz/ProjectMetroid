// Decompiled with JetBrains decompiler
// Type: ProjectM.GameplayEventIdMapping
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct GameplayEventIdMapping
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NextTriggerTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_TriggerCooldown;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameplayEventId;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxTriggers;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentTriggers;
    private static readonly System.IntPtr NativeFieldInfoPtr_TriggerMultipleTimes;
    private static readonly System.IntPtr NativeMethodInfoPtr_Check_Public_Static_Boolean_DynamicBuffer_1_GameplayEventIdMapping_Int32_Int32_GameplayEventId_Double_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MarkUsed_Public_Static_Void_DynamicBuffer_1_GameplayEventIdMapping_Int32_Double_0;
    [FieldOffset(0)]
    public double NextTriggerTime;
    [FieldOffset(8)]
    public float TriggerCooldown;
    [FieldOffset(12)]
    public GameplayEventId GameplayEventId;
    [FieldOffset(20)]
    public int MaxTriggers;
    [FieldOffset(24)]
    public int CurrentTriggers;
    [FieldOffset(28)]
    public bool TriggerMultipleTimes;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1008115, RefRangeEnd = 1008118, XrefRangeStart = 1008106, XrefRangeEnd = 1008115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool Check(
      DynamicBuffer<GameplayEventIdMapping> buffer,
      int eventIdIndex,
      int eventIdCount,
      GameplayEventId eventId,
      double serverTime,
      bool markUsed = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &buffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &eventIdIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &eventIdCount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &eventId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &serverTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &markUsed;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayEventIdMapping.NativeMethodInfoPtr_Check_Public_Static_Boolean_DynamicBuffer_1_GameplayEventIdMapping_Int32_Int32_GameplayEventId_Double_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1008124, RefRangeEnd = 1008127, XrefRangeStart = 1008118, XrefRangeEnd = 1008124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void MarkUsed(
      DynamicBuffer<GameplayEventIdMapping> buffer,
      int eventIdIndex,
      double serverTime)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &buffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &eventIdIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &serverTime;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayEventIdMapping.NativeMethodInfoPtr_MarkUsed_Public_Static_Void_DynamicBuffer_1_GameplayEventIdMapping_Int32_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GameplayEventIdMapping()
    {
      Il2CppClassPointerStore<GameplayEventIdMapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (GameplayEventIdMapping));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayEventIdMapping>.NativeClassPtr);
      GameplayEventIdMapping.NativeFieldInfoPtr_NextTriggerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayEventIdMapping>.NativeClassPtr, nameof (NextTriggerTime));
      GameplayEventIdMapping.NativeFieldInfoPtr_TriggerCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayEventIdMapping>.NativeClassPtr, nameof (TriggerCooldown));
      GameplayEventIdMapping.NativeFieldInfoPtr_GameplayEventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayEventIdMapping>.NativeClassPtr, nameof (GameplayEventId));
      GameplayEventIdMapping.NativeFieldInfoPtr_MaxTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayEventIdMapping>.NativeClassPtr, nameof (MaxTriggers));
      GameplayEventIdMapping.NativeFieldInfoPtr_CurrentTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayEventIdMapping>.NativeClassPtr, nameof (CurrentTriggers));
      GameplayEventIdMapping.NativeFieldInfoPtr_TriggerMultipleTimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayEventIdMapping>.NativeClassPtr, nameof (TriggerMultipleTimes));
      GameplayEventIdMapping.NativeMethodInfoPtr_Check_Public_Static_Boolean_DynamicBuffer_1_GameplayEventIdMapping_Int32_Int32_GameplayEventId_Double_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayEventIdMapping>.NativeClassPtr, 100678299);
      GameplayEventIdMapping.NativeMethodInfoPtr_MarkUsed_Public_Static_Void_DynamicBuffer_1_GameplayEventIdMapping_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayEventIdMapping>.NativeClassPtr, 100678300);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameplayEventIdMapping>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
