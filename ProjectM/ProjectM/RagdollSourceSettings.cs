// Decompiled with JetBrains decompiler
// Type: ProjectM.RagdollSourceSettings
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class RagdollSourceSettings : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_Force;
    private static readonly IntPtr NativeFieldInfoPtr_InheritDirection;
    private static readonly IntPtr NativeFieldInfoPtr_InheritDirectionWeight;
    private static readonly IntPtr NativeFieldInfoPtr_AwayFromSource;
    private static readonly IntPtr NativeFieldInfoPtr_AwayFromSourceWeight;
    private static readonly IntPtr NativeFieldInfoPtr_TowardsSource;
    private static readonly IntPtr NativeFieldInfoPtr_TowardsSourceWeight;
    private static readonly IntPtr NativeFieldInfoPtr_UseManualDirection;
    private static readonly IntPtr NativeFieldInfoPtr_ManualDirection;
    private static readonly IntPtr NativeFieldInfoPtr_ManualDirectionWeight;
    private static readonly IntPtr NativeFieldInfoPtr__Guid;
    private static readonly IntPtr NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe PrefabGUID PrefabGuid
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067554, XrefRangeEnd = 1067555, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(RagdollSourceSettings.NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067555, XrefRangeEnd = 1067577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RagdollSourceSettings.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067577, XrefRangeEnd = 1067578, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RagdollSourceSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RagdollSourceSettings>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RagdollSourceSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RagdollSourceSettings()
    {
      Il2CppClassPointerStore<RagdollSourceSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (RagdollSourceSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RagdollSourceSettings>.NativeClassPtr);
      RagdollSourceSettings.NativeFieldInfoPtr_Force = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollSourceSettings>.NativeClassPtr, nameof (Force));
      RagdollSourceSettings.NativeFieldInfoPtr_InheritDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollSourceSettings>.NativeClassPtr, nameof (InheritDirection));
      RagdollSourceSettings.NativeFieldInfoPtr_InheritDirectionWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollSourceSettings>.NativeClassPtr, nameof (InheritDirectionWeight));
      RagdollSourceSettings.NativeFieldInfoPtr_AwayFromSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollSourceSettings>.NativeClassPtr, nameof (AwayFromSource));
      RagdollSourceSettings.NativeFieldInfoPtr_AwayFromSourceWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollSourceSettings>.NativeClassPtr, nameof (AwayFromSourceWeight));
      RagdollSourceSettings.NativeFieldInfoPtr_TowardsSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollSourceSettings>.NativeClassPtr, nameof (TowardsSource));
      RagdollSourceSettings.NativeFieldInfoPtr_TowardsSourceWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollSourceSettings>.NativeClassPtr, nameof (TowardsSourceWeight));
      RagdollSourceSettings.NativeFieldInfoPtr_UseManualDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollSourceSettings>.NativeClassPtr, nameof (UseManualDirection));
      RagdollSourceSettings.NativeFieldInfoPtr_ManualDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollSourceSettings>.NativeClassPtr, nameof (ManualDirection));
      RagdollSourceSettings.NativeFieldInfoPtr_ManualDirectionWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollSourceSettings>.NativeClassPtr, nameof (ManualDirectionWeight));
      RagdollSourceSettings.NativeFieldInfoPtr__Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollSourceSettings>.NativeClassPtr, nameof (_Guid));
      RagdollSourceSettings.NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollSourceSettings>.NativeClassPtr, 100683981);
      RagdollSourceSettings.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollSourceSettings>.NativeClassPtr, 100683982);
      RagdollSourceSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollSourceSettings>.NativeClassPtr, 100683983);
    }

    public RagdollSourceSettings(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float Force
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollSourceSettings.NativeFieldInfoPtr_Force));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollSourceSettings.NativeFieldInfoPtr_Force)) = value;
      }
    }

    public unsafe bool InheritDirection
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollSourceSettings.NativeFieldInfoPtr_InheritDirection));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollSourceSettings.NativeFieldInfoPtr_InheritDirection)) = value;
      }
    }

    public unsafe float InheritDirectionWeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollSourceSettings.NativeFieldInfoPtr_InheritDirectionWeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollSourceSettings.NativeFieldInfoPtr_InheritDirectionWeight)) = value;
      }
    }

    public unsafe bool AwayFromSource
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollSourceSettings.NativeFieldInfoPtr_AwayFromSource));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollSourceSettings.NativeFieldInfoPtr_AwayFromSource)) = value;
      }
    }

    public unsafe float AwayFromSourceWeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollSourceSettings.NativeFieldInfoPtr_AwayFromSourceWeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollSourceSettings.NativeFieldInfoPtr_AwayFromSourceWeight)) = value;
      }
    }

    public unsafe bool TowardsSource
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollSourceSettings.NativeFieldInfoPtr_TowardsSource));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollSourceSettings.NativeFieldInfoPtr_TowardsSource)) = value;
      }
    }

    public unsafe float TowardsSourceWeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollSourceSettings.NativeFieldInfoPtr_TowardsSourceWeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollSourceSettings.NativeFieldInfoPtr_TowardsSourceWeight)) = value;
      }
    }

    public unsafe bool UseManualDirection
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollSourceSettings.NativeFieldInfoPtr_UseManualDirection));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollSourceSettings.NativeFieldInfoPtr_UseManualDirection)) = value;
      }
    }

    public unsafe float3 ManualDirection
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollSourceSettings.NativeFieldInfoPtr_ManualDirection));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollSourceSettings.NativeFieldInfoPtr_ManualDirection)) = value;
      }
    }

    public unsafe float ManualDirectionWeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollSourceSettings.NativeFieldInfoPtr_ManualDirectionWeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollSourceSettings.NativeFieldInfoPtr_ManualDirectionWeight)) = value;
      }
    }

    public unsafe string _Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollSourceSettings.NativeFieldInfoPtr__Guid)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RagdollSourceSettings.NativeFieldInfoPtr__Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
