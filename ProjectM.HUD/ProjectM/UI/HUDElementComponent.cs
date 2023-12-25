// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.HUDElementComponent
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class HUDElementComponent : StunGUIBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_ElementType;
    private static readonly IntPtr NativeFieldInfoPtr_HideObjects;
    private static readonly IntPtr NativeMethodInfoPtr_UpdateVisibility_Public_Void_HUDElementType_0;
    private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1266479, RefRangeEnd = 1266480, XrefRangeStart = 1266477, XrefRangeEnd = 1266479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateVisibility(HUDElementType hiddenElements)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &hiddenElements;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HUDElementComponent.NativeMethodInfoPtr_UpdateVisibility_Public_Void_HUDElementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266480, XrefRangeEnd = 1266498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HUDElementComponent.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HUDElementComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HUDElementComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HUDElementComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HUDElementComponent()
    {
      Il2CppClassPointerStore<HUDElementComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (HUDElementComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HUDElementComponent>.NativeClassPtr);
      HUDElementComponent.NativeFieldInfoPtr_ElementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDElementComponent>.NativeClassPtr, nameof (ElementType));
      HUDElementComponent.NativeFieldInfoPtr_HideObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDElementComponent>.NativeClassPtr, nameof (HideObjects));
      HUDElementComponent.NativeMethodInfoPtr_UpdateVisibility_Public_Void_HUDElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDElementComponent>.NativeClassPtr, 100667617);
      HUDElementComponent.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDElementComponent>.NativeClassPtr, 100667618);
      HUDElementComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDElementComponent>.NativeClassPtr, 100667619);
    }

    public HUDElementComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe HUDElementType ElementType
    {
      get
      {
        return *(HUDElementType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDElementComponent.NativeFieldInfoPtr_ElementType));
      }
      [param: In] set
      {
        *(HUDElementType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDElementComponent.NativeFieldInfoPtr_ElementType)) = value;
      }
    }

    public unsafe Il2CppReferenceArray<GameObject> HideObjects
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDElementComponent.NativeFieldInfoPtr_HideObjects));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<GameObject>) null : new Il2CppReferenceArray<GameObject>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HUDElementComponent.NativeFieldInfoPtr_HideObjects), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
