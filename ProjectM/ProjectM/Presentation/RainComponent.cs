// Decompiled with JetBrains decompiler
// Type: ProjectM.Presentation.RainComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Presentation
{
  public class RainComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_RainGameObject;
    private static readonly IntPtr NativeFieldInfoPtr__ForceEnable;
    private static readonly IntPtr NativeMethodInfoPtr_get_ForceEnable_Public_get_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_ForceEnable_Public_set_Void_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetForceRainEnabledState_Private_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe bool ForceEnable
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(RainComponent.NativeMethodInfoPtr_get_ForceEnable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112840, XrefRangeEnd = 1112845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RainComponent.NativeMethodInfoPtr_set_ForceEnable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112845, XrefRangeEnd = 1112848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetForceRainEnabledState()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(RainComponent.NativeMethodInfoPtr_GetForceRainEnabledState_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112848, XrefRangeEnd = 1112852, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Start()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RainComponent.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RainComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RainComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RainComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RainComponent()
    {
      Il2CppClassPointerStore<RainComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Presentation", nameof (RainComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RainComponent>.NativeClassPtr);
      RainComponent.NativeFieldInfoPtr_RainGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainComponent>.NativeClassPtr, nameof (RainGameObject));
      RainComponent.NativeFieldInfoPtr__ForceEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RainComponent>.NativeClassPtr, nameof (_ForceEnable));
      RainComponent.NativeMethodInfoPtr_get_ForceEnable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainComponent>.NativeClassPtr, 100688092);
      RainComponent.NativeMethodInfoPtr_set_ForceEnable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainComponent>.NativeClassPtr, 100688093);
      RainComponent.NativeMethodInfoPtr_GetForceRainEnabledState_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainComponent>.NativeClassPtr, 100688094);
      RainComponent.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainComponent>.NativeClassPtr, 100688095);
      RainComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RainComponent>.NativeClassPtr, 100688096);
    }

    public RainComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameObject RainGameObject
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RainComponent.NativeFieldInfoPtr_RainGameObject));
        return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RainComponent.NativeFieldInfoPtr_RainGameObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _ForceEnable
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RainComponent.NativeFieldInfoPtr__ForceEnable));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RainComponent.NativeFieldInfoPtr__ForceEnable)) = value;
      }
    }
  }
}
