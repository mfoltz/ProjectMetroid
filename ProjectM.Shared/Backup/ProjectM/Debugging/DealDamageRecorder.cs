// Decompiled with JetBrains decompiler
// Type: ProjectM.Debugging.DealDamageRecorder
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM.Debugging
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DealDamageRecorder
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Data;
    private static readonly System.IntPtr NativeFieldInfoPtr_Index;
    private static readonly System.IntPtr NativeFieldInfoPtr_Created;
    private static readonly System.IntPtr NativeFieldInfoPtr_RecordingDisabled;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetModifiers_Public_Void_Modifiers_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetTargetEntityCategory_Public_Void_EntityCategory_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetResult_Public_Void_DealDamageResultEnum_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetDamage_Public_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetDealerAndTargetType_Public_Void_DealDamageTargetTypeEnum_DealDamageTargetTypeEnum_0;
    [FieldOffset(0)]
    public NativeList<GameplayDebugRecord> Data;
    [FieldOffset(16)]
    public int Index;
    [FieldOffset(20)]
    public bool Created;
    [FieldOffset(21)]
    public bool RecordingDisabled;

    public unsafe bool Enabled
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 770587, RefRangeEnd = 770588, XrefRangeStart = 770587, XrefRangeEnd = 770587, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DealDamageRecorder.NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 770598, RefRangeEnd = 770599, XrefRangeStart = 770588, XrefRangeEnd = 770598, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetModifiers(DealDamageEventCommand.Modifiers modifiers)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &modifiers;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DealDamageRecorder.NativeMethodInfoPtr_SetModifiers_Public_Void_Modifiers_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 770609, RefRangeEnd = 770610, XrefRangeStart = 770599, XrefRangeEnd = 770609, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetTargetEntityCategory(EntityCategory entityCategory)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entityCategory;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DealDamageRecorder.NativeMethodInfoPtr_SetTargetEntityCategory_Public_Void_EntityCategory_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 770620, RefRangeEnd = 770624, XrefRangeStart = 770610, XrefRangeEnd = 770620, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetResult(DealDamageResultEnum result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &result;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DealDamageRecorder.NativeMethodInfoPtr_SetResult_Public_Void_DealDamageResultEnum_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 770634, RefRangeEnd = 770635, XrefRangeStart = 770624, XrefRangeEnd = 770634, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetDamage(float damage)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &damage;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DealDamageRecorder.NativeMethodInfoPtr_SetDamage_Public_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 770645, RefRangeEnd = 770646, XrefRangeStart = 770635, XrefRangeEnd = 770645, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetDealerAndTargetType(
      DealDamageTargetTypeEnum dealerType,
      DealDamageTargetTypeEnum targetType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &dealerType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DealDamageRecorder.NativeMethodInfoPtr_SetDealerAndTargetType_Public_Void_DealDamageTargetTypeEnum_DealDamageTargetTypeEnum_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DealDamageRecorder()
    {
      Il2CppClassPointerStore<DealDamageRecorder>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Debugging", nameof (DealDamageRecorder));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealDamageRecorder>.NativeClassPtr);
      DealDamageRecorder.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageRecorder>.NativeClassPtr, nameof (Data));
      DealDamageRecorder.NativeFieldInfoPtr_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageRecorder>.NativeClassPtr, nameof (Index));
      DealDamageRecorder.NativeFieldInfoPtr_Created = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageRecorder>.NativeClassPtr, nameof (Created));
      DealDamageRecorder.NativeFieldInfoPtr_RecordingDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageRecorder>.NativeClassPtr, nameof (RecordingDisabled));
      DealDamageRecorder.NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealDamageRecorder>.NativeClassPtr, 100668245);
      DealDamageRecorder.NativeMethodInfoPtr_SetModifiers_Public_Void_Modifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealDamageRecorder>.NativeClassPtr, 100668246);
      DealDamageRecorder.NativeMethodInfoPtr_SetTargetEntityCategory_Public_Void_EntityCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealDamageRecorder>.NativeClassPtr, 100668247);
      DealDamageRecorder.NativeMethodInfoPtr_SetResult_Public_Void_DealDamageResultEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealDamageRecorder>.NativeClassPtr, 100668248);
      DealDamageRecorder.NativeMethodInfoPtr_SetDamage_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealDamageRecorder>.NativeClassPtr, 100668249);
      DealDamageRecorder.NativeMethodInfoPtr_SetDealerAndTargetType_Public_Void_DealDamageTargetTypeEnum_DealDamageTargetTypeEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealDamageRecorder>.NativeClassPtr, 100668250);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DealDamageRecorder>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
