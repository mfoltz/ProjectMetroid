// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.WindMotorNodeOverride
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
namespace ProjectM.Sequencer
{
  [Serializable]
  public class WindMotorNodeOverride : SequenceNodeOverride
  {
    private static readonly IntPtr NativeFieldInfoPtr_GUID;
    private static readonly IntPtr NativeFieldInfoPtr_MotorType_Override;
    private static readonly IntPtr NativeFieldInfoPtr_Position_Override;
    private static readonly IntPtr NativeFieldInfoPtr_Force_Override;
    private static readonly IntPtr NativeFieldInfoPtr_Range_Override;
    private static readonly IntPtr NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_get_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_HasNodeAnyOverride_Protected_Virtual_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_CreateNew_Public_Static_WindMotorNodeOverride_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_CreateDefault_Public_Static_WindMotorNodeOverride_0;
    private static readonly IntPtr NativeMethodInfoPtr_AddGameObjectReferences_Public_Virtual_Void_List_1_GameObject_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetDeterministicHash_Public_Virtual_Int32_Object_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public override unsafe int CurrentVersion
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 29193, RefRangeEnd = 29196, XrefRangeStart = 29193, XrefRangeEnd = 29196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), WindMotorNodeOverride.NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(1858)]
    [CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool HasNodeAnyOverride()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), WindMotorNodeOverride.NativeMethodInfoPtr_HasNodeAnyOverride_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094121, XrefRangeEnd = 1094130, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe WindMotorNodeOverride CreateNew(string nodeGuid)
    {
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(nodeGuid);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(WindMotorNodeOverride.NativeMethodInfoPtr_CreateNew_Public_Static_WindMotorNodeOverride_String_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (WindMotorNodeOverride) null : new WindMotorNodeOverride(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1094141, RefRangeEnd = 1094142, XrefRangeStart = 1094130, XrefRangeEnd = 1094141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe WindMotorNodeOverride CreateDefault()
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(WindMotorNodeOverride.NativeMethodInfoPtr_CreateDefault_Public_Static_WindMotorNodeOverride_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (WindMotorNodeOverride) null : new WindMotorNodeOverride(pointer);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void AddGameObjectReferences(List<GameObject> references)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) references);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), WindMotorNodeOverride.NativeMethodInfoPtr_AddGameObjectReferences_Public_Virtual_Void_List_1_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094142, XrefRangeEnd = 1094150, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetDeterministicHash(UnityEngine.Object sourceAsset)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sourceAsset);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), WindMotorNodeOverride.NativeMethodInfoPtr_GetDeterministicHash_Public_Virtual_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe WindMotorNodeOverride()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WindMotorNodeOverride>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WindMotorNodeOverride.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static WindMotorNodeOverride()
    {
      Il2CppClassPointerStore<WindMotorNodeOverride>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (WindMotorNodeOverride));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindMotorNodeOverride>.NativeClassPtr);
      WindMotorNodeOverride.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindMotorNodeOverride>.NativeClassPtr, nameof (GUID));
      WindMotorNodeOverride.NativeFieldInfoPtr_MotorType_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindMotorNodeOverride>.NativeClassPtr, nameof (MotorType_Override));
      WindMotorNodeOverride.NativeFieldInfoPtr_Position_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindMotorNodeOverride>.NativeClassPtr, nameof (Position_Override));
      WindMotorNodeOverride.NativeFieldInfoPtr_Force_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindMotorNodeOverride>.NativeClassPtr, nameof (Force_Override));
      WindMotorNodeOverride.NativeFieldInfoPtr_Range_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindMotorNodeOverride>.NativeClassPtr, nameof (Range_Override));
      WindMotorNodeOverride.NativeMethodInfoPtr_get_CurrentVersion_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindMotorNodeOverride>.NativeClassPtr, 100686679);
      WindMotorNodeOverride.NativeMethodInfoPtr_HasNodeAnyOverride_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindMotorNodeOverride>.NativeClassPtr, 100686680);
      WindMotorNodeOverride.NativeMethodInfoPtr_CreateNew_Public_Static_WindMotorNodeOverride_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindMotorNodeOverride>.NativeClassPtr, 100686681);
      WindMotorNodeOverride.NativeMethodInfoPtr_CreateDefault_Public_Static_WindMotorNodeOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindMotorNodeOverride>.NativeClassPtr, 100686682);
      WindMotorNodeOverride.NativeMethodInfoPtr_AddGameObjectReferences_Public_Virtual_Void_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindMotorNodeOverride>.NativeClassPtr, 100686683);
      WindMotorNodeOverride.NativeMethodInfoPtr_GetDeterministicHash_Public_Virtual_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindMotorNodeOverride>.NativeClassPtr, 100686684);
      WindMotorNodeOverride.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindMotorNodeOverride>.NativeClassPtr, 100686685);
    }

    public WindMotorNodeOverride(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string GUID
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindMotorNodeOverride.NativeFieldInfoPtr_GUID)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WindMotorNodeOverride.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe int MotorType_Override
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindMotorNodeOverride.NativeFieldInfoPtr_MotorType_Override));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindMotorNodeOverride.NativeFieldInfoPtr_MotorType_Override)) = value;
      }
    }

    public unsafe float3 Position_Override
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindMotorNodeOverride.NativeFieldInfoPtr_Position_Override));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindMotorNodeOverride.NativeFieldInfoPtr_Position_Override)) = value;
      }
    }

    public unsafe float3 Force_Override
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindMotorNodeOverride.NativeFieldInfoPtr_Force_Override));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindMotorNodeOverride.NativeFieldInfoPtr_Force_Override)) = value;
      }
    }

    public unsafe float Range_Override
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindMotorNodeOverride.NativeFieldInfoPtr_Range_Override));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindMotorNodeOverride.NativeFieldInfoPtr_Range_Override)) = value;
      }
    }
  }
}
