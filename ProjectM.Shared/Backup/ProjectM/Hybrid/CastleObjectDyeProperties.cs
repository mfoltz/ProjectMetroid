// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.CastleObjectDyeProperties
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Hybrid
{
  public class CastleObjectDyeProperties : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ColorProperties;
    private static readonly System.IntPtr NativeMethodInfoPtr_EditOrAddColorProperty_Public_Void_Int32_Int32_Color_byref_Renderer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 796136, RefRangeEnd = 796137, XrefRangeStart = 796129, XrefRangeEnd = 796136, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void EditOrAddColorProperty(
      int rendererIndex,
      int shaderPropID,
      Color newColorValue,
      [In] ref Renderer renderer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
      numPtr1[0] = (System.IntPtr) &rendererIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &shaderPropID;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &newColorValue;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) renderer);
      System.IntPtr* numPtr2 = &ptr;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleObjectDyeProperties.NativeMethodInfoPtr_EditOrAddColorProperty_Public_Void_Int32_Int32_Color_byref_Renderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Renderer local = ref renderer;
      System.IntPtr pointer = ptr;
      Renderer renderer1 = pointer == System.IntPtr.Zero ? (Renderer) null : new Renderer(pointer);
      local = renderer1;
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 796137, XrefRangeEnd = 796141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Clear()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleObjectDyeProperties.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleObjectDyeProperties()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastleObjectDyeProperties>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleObjectDyeProperties.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CastleObjectDyeProperties()
    {
      Il2CppClassPointerStore<CastleObjectDyeProperties>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Hybrid", nameof (CastleObjectDyeProperties));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleObjectDyeProperties>.NativeClassPtr);
      CastleObjectDyeProperties.NativeFieldInfoPtr_ColorProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleObjectDyeProperties>.NativeClassPtr, nameof (ColorProperties));
      CastleObjectDyeProperties.NativeMethodInfoPtr_EditOrAddColorProperty_Public_Void_Int32_Int32_Color_byref_Renderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleObjectDyeProperties>.NativeClassPtr, 100670257);
      CastleObjectDyeProperties.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleObjectDyeProperties>.NativeClassPtr, 100670258);
      CastleObjectDyeProperties.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleObjectDyeProperties>.NativeClassPtr, 100670259);
    }

    public CastleObjectDyeProperties(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Dictionary<DyePropertyKey, Color> ColorProperties
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleObjectDyeProperties.NativeFieldInfoPtr_ColorProperties));
        return pointer == System.IntPtr.Zero ? (Dictionary<DyePropertyKey, Color>) null : new Dictionary<DyePropertyKey, Color>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleObjectDyeProperties.NativeFieldInfoPtr_ColorProperties), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
