// Decompiled with JetBrains decompiler
// Type: ProjectM.ECBSyncPointManager
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class ECBSyncPointManager : SystemBase
  {
    private static readonly IntPtr NativeFieldInfoPtr__CurrentSyncPoint_k__BackingField;
    private static readonly IntPtr NativeFieldInfoPtr__EnableHardSyncPoints;
    private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSyncPoint_Public_get_ECBSyncPointId_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_CurrentSyncPoint_Private_set_Void_ECBSyncPointId_0;
    private static readonly IntPtr NativeMethodInfoPtr_TriggerFrameSyncPoint_Public_Void_ComponentSystemBase_0;
    private static readonly IntPtr NativeMethodInfoPtr_TriggerHardSyncPoint_Public_Void_ComponentSystemBase_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    public unsafe ECBSyncPointId CurrentSyncPoint
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 73358, RefRangeEnd = 73412, XrefRangeStart = 73358, XrefRangeEnd = 73412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(ECBSyncPointManager.NativeMethodInfoPtr_get_CurrentSyncPoint_Public_get_ECBSyncPointId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ECBSyncPointId*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ECBSyncPointManager.NativeMethodInfoPtr_set_CurrentSyncPoint_Private_set_Void_ECBSyncPointId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757247, XrefRangeEnd = 757248, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TriggerFrameSyncPoint(ComponentSystemBase cause)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cause);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ECBSyncPointManager.NativeMethodInfoPtr_TriggerFrameSyncPoint_Public_Void_ComponentSystemBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 757249, RefRangeEnd = 757250, XrefRangeStart = 757248, XrefRangeEnd = 757249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TriggerHardSyncPoint(ComponentSystemBase cause)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cause);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ECBSyncPointManager.NativeMethodInfoPtr_TriggerHardSyncPoint_Public_Void_ComponentSystemBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757250, XrefRangeEnd = 757254, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ECBSyncPointManager.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757254, XrefRangeEnd = 757255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ECBSyncPointManager.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ECBSyncPointManager()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ECBSyncPointManager>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ECBSyncPointManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ECBSyncPointManager.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ECBSyncPointManager()
    {
      Il2CppClassPointerStore<ECBSyncPointManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ECBSyncPointManager));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ECBSyncPointManager>.NativeClassPtr);
      ECBSyncPointManager.NativeFieldInfoPtr__CurrentSyncPoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ECBSyncPointManager>.NativeClassPtr, "<CurrentSyncPoint>k__BackingField");
      ECBSyncPointManager.NativeFieldInfoPtr__EnableHardSyncPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ECBSyncPointManager>.NativeClassPtr, nameof (_EnableHardSyncPoints));
      ECBSyncPointManager.NativeMethodInfoPtr_get_CurrentSyncPoint_Public_get_ECBSyncPointId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ECBSyncPointManager>.NativeClassPtr, 100666877);
      ECBSyncPointManager.NativeMethodInfoPtr_set_CurrentSyncPoint_Private_set_Void_ECBSyncPointId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ECBSyncPointManager>.NativeClassPtr, 100666878);
      ECBSyncPointManager.NativeMethodInfoPtr_TriggerFrameSyncPoint_Public_Void_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ECBSyncPointManager>.NativeClassPtr, 100666879);
      ECBSyncPointManager.NativeMethodInfoPtr_TriggerHardSyncPoint_Public_Void_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ECBSyncPointManager>.NativeClassPtr, 100666880);
      ECBSyncPointManager.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ECBSyncPointManager>.NativeClassPtr, 100666881);
      ECBSyncPointManager.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ECBSyncPointManager>.NativeClassPtr, 100666882);
      ECBSyncPointManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ECBSyncPointManager>.NativeClassPtr, 100666883);
      ECBSyncPointManager.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ECBSyncPointManager>.NativeClassPtr, 100666884);
    }

    public ECBSyncPointManager(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ECBSyncPointId _CurrentSyncPoint_k__BackingField
    {
      get
      {
        return *(ECBSyncPointId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ECBSyncPointManager.NativeFieldInfoPtr__CurrentSyncPoint_k__BackingField));
      }
      [param: In] set
      {
        *(ECBSyncPointId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ECBSyncPointManager.NativeFieldInfoPtr__CurrentSyncPoint_k__BackingField)) = value;
      }
    }

    public unsafe bool _EnableHardSyncPoints
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ECBSyncPointManager.NativeFieldInfoPtr__EnableHardSyncPoints));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ECBSyncPointManager.NativeFieldInfoPtr__EnableHardSyncPoints)) = value;
      }
    }
  }
}
