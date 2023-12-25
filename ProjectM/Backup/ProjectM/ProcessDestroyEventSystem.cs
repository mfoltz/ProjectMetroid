// Decompiled with JetBrains decompiler
// Type: ProjectM.ProcessDestroyEventSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class ProcessDestroyEventSystem : SystemBase
  {
    private static readonly IntPtr NativeFieldInfoPtr__EventQuery;
    private static readonly IntPtr NativeFieldInfoPtr__PrintState;
    private static readonly IntPtr NativeFieldInfoPtr_LogDestroys;
    private static readonly IntPtr NativeMethodInfoPtr_PrintState_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_TagNewDestroyedEntity_Private_Void_Entity_DestroyReason_0;
    private static readonly IntPtr NativeMethodInfoPtr_DestroyChildrenRecursive_Private_Void_Entity_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 639894, RefRangeEnd = 639895, XrefRangeStart = 639894, XrefRangeEnd = 639895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PrintState()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProcessDestroyEventSystem.NativeMethodInfoPtr_PrintState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1005256, XrefRangeEnd = 1005263, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProcessDestroyEventSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1005263, XrefRangeEnd = 1005388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProcessDestroyEventSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1005413, RefRangeEnd = 1005416, XrefRangeStart = 1005388, XrefRangeEnd = 1005413, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TagNewDestroyedEntity(Entity entity, DestroyReason reason)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &reason;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProcessDestroyEventSystem.NativeMethodInfoPtr_TagNewDestroyedEntity_Private_Void_Entity_DestroyReason_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1005461, RefRangeEnd = 1005464, XrefRangeStart = 1005416, XrefRangeEnd = 1005461, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DestroyChildrenRecursive(Entity parent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &parent;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProcessDestroyEventSystem.NativeMethodInfoPtr_DestroyChildrenRecursive_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProcessDestroyEventSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProcessDestroyEventSystem>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProcessDestroyEventSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProcessDestroyEventSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProcessDestroyEventSystem()
    {
      Il2CppClassPointerStore<ProcessDestroyEventSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ProcessDestroyEventSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProcessDestroyEventSystem>.NativeClassPtr);
      ProcessDestroyEventSystem.NativeFieldInfoPtr__EventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessDestroyEventSystem>.NativeClassPtr, nameof (_EventQuery));
      ProcessDestroyEventSystem.NativeFieldInfoPtr__PrintState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessDestroyEventSystem>.NativeClassPtr, nameof (_PrintState));
      ProcessDestroyEventSystem.NativeFieldInfoPtr_LogDestroys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessDestroyEventSystem>.NativeClassPtr, nameof (LogDestroys));
      ProcessDestroyEventSystem.NativeMethodInfoPtr_PrintState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessDestroyEventSystem>.NativeClassPtr, 100677992);
      ProcessDestroyEventSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessDestroyEventSystem>.NativeClassPtr, 100677993);
      ProcessDestroyEventSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessDestroyEventSystem>.NativeClassPtr, 100677994);
      ProcessDestroyEventSystem.NativeMethodInfoPtr_TagNewDestroyedEntity_Private_Void_Entity_DestroyReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessDestroyEventSystem>.NativeClassPtr, 100677995);
      ProcessDestroyEventSystem.NativeMethodInfoPtr_DestroyChildrenRecursive_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessDestroyEventSystem>.NativeClassPtr, 100677996);
      ProcessDestroyEventSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessDestroyEventSystem>.NativeClassPtr, 100677997);
      ProcessDestroyEventSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessDestroyEventSystem>.NativeClassPtr, 100677998);
    }

    public ProcessDestroyEventSystem(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _EventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProcessDestroyEventSystem.NativeFieldInfoPtr__EventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProcessDestroyEventSystem.NativeFieldInfoPtr__EventQuery)) = value;
      }
    }

    public unsafe bool _PrintState
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProcessDestroyEventSystem.NativeFieldInfoPtr__PrintState));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProcessDestroyEventSystem.NativeFieldInfoPtr__PrintState)) = value;
      }
    }

    public unsafe bool LogDestroys
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProcessDestroyEventSystem.NativeFieldInfoPtr_LogDestroys));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProcessDestroyEventSystem.NativeFieldInfoPtr_LogDestroys)) = value;
      }
    }
  }
}
