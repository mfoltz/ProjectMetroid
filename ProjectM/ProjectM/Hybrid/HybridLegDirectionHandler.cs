// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.HybridLegDirectionHandler
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.Hybrid
{
  public class HybridLegDirectionHandler : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Head;
    private static readonly IntPtr NativeFieldInfoPtr_Body;
    private static readonly IntPtr NativeFieldInfoPtr__UpdateAnimatorParameter;
    private static readonly IntPtr NativeFieldInfoPtr_FloatHeadAngle;
    private static readonly IntPtr NativeFieldInfoPtr_Animator;
    private static readonly IntPtr NativeMethodInfoPtr_get_UpdateAnimatorParameter_Public_get_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetAnimatorParameter_Public_Void_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_AddComponent_Public_Virtual_Final_New_Void_World_PrefabLookupMap_Entity_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe bool UpdateAnimatorParameter
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridLegDirectionHandler.NativeMethodInfoPtr_get_UpdateAnimatorParameter_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155380, XrefRangeEnd = 1155389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetAnimatorParameter(float headAngle)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &headAngle;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridLegDirectionHandler.NativeMethodInfoPtr_SetAnimatorParameter_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void AddComponent(
      World world,
      PrefabLookupMap prefabLookupMap,
      Entity hybridEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &prefabLookupMap;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &hybridEntity;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridLegDirectionHandler.NativeMethodInfoPtr_AddComponent_Public_Virtual_Final_New_Void_World_PrefabLookupMap_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HybridLegDirectionHandler()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HybridLegDirectionHandler>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridLegDirectionHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HybridLegDirectionHandler()
    {
      Il2CppClassPointerStore<HybridLegDirectionHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Hybrid", nameof (HybridLegDirectionHandler));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridLegDirectionHandler>.NativeClassPtr);
      HybridLegDirectionHandler.NativeFieldInfoPtr_Head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLegDirectionHandler>.NativeClassPtr, nameof (Head));
      HybridLegDirectionHandler.NativeFieldInfoPtr_Body = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLegDirectionHandler>.NativeClassPtr, nameof (Body));
      HybridLegDirectionHandler.NativeFieldInfoPtr__UpdateAnimatorParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLegDirectionHandler>.NativeClassPtr, nameof (_UpdateAnimatorParameter));
      HybridLegDirectionHandler.NativeFieldInfoPtr_FloatHeadAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLegDirectionHandler>.NativeClassPtr, nameof (FloatHeadAngle));
      HybridLegDirectionHandler.NativeFieldInfoPtr_Animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridLegDirectionHandler>.NativeClassPtr, nameof (Animator));
      HybridLegDirectionHandler.NativeMethodInfoPtr_get_UpdateAnimatorParameter_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridLegDirectionHandler>.NativeClassPtr, 100691924);
      HybridLegDirectionHandler.NativeMethodInfoPtr_SetAnimatorParameter_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridLegDirectionHandler>.NativeClassPtr, 100691925);
      HybridLegDirectionHandler.NativeMethodInfoPtr_AddComponent_Public_Virtual_Final_New_Void_World_PrefabLookupMap_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridLegDirectionHandler>.NativeClassPtr, 100691926);
      HybridLegDirectionHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridLegDirectionHandler>.NativeClassPtr, 100691927);
    }

    public HybridLegDirectionHandler(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Transform Head
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLegDirectionHandler.NativeFieldInfoPtr_Head));
        return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridLegDirectionHandler.NativeFieldInfoPtr_Head), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform Body
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLegDirectionHandler.NativeFieldInfoPtr_Body));
        return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridLegDirectionHandler.NativeFieldInfoPtr_Body), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _UpdateAnimatorParameter
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLegDirectionHandler.NativeFieldInfoPtr__UpdateAnimatorParameter));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLegDirectionHandler.NativeFieldInfoPtr__UpdateAnimatorParameter)) = value;
      }
    }

    public static unsafe int FloatHeadAngle
    {
      get
      {
        int floatHeadAngle;
        IL2CPP.il2cpp_field_static_get_value(HybridLegDirectionHandler.NativeFieldInfoPtr_FloatHeadAngle, (void*) &floatHeadAngle);
        return floatHeadAngle;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HybridLegDirectionHandler.NativeFieldInfoPtr_FloatHeadAngle, (void*) &value);
      }
    }

    public unsafe Animator Animator
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridLegDirectionHandler.NativeFieldInfoPtr_Animator));
        return pointer == IntPtr.Zero ? (Animator) null : new Animator(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridLegDirectionHandler.NativeFieldInfoPtr_Animator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
