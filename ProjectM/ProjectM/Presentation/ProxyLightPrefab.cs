// Decompiled with JetBrains decompiler
// Type: ProjectM.Presentation.ProxyLightPrefab
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

#nullable disable
namespace ProjectM.Presentation
{
  public class ProxyLightPrefab : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_color;
    private static readonly System.IntPtr NativeFieldInfoPtr_range;
    private static readonly System.IntPtr NativeFieldInfoPtr_intensity;
    private static readonly System.IntPtr NativeFieldInfoPtr_cookie;
    private static readonly System.IntPtr NativeFieldInfoPtr_spotLightShape;
    private static readonly System.IntPtr NativeFieldInfoPtr_shapeRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_spotAngle;
    private static readonly System.IntPtr NativeFieldInfoPtr_innerSpotPercent;
    private static readonly System.IntPtr NativeFieldInfoPtr_aspectRatio;
    private static readonly System.IntPtr NativeFieldInfoPtr_shapeWidth;
    private static readonly System.IntPtr NativeFieldInfoPtr_shapeHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_type;
    private static readonly System.IntPtr NativeFieldInfoPtr_DescriptionString;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyFrom_Public_Static_ProxyLightPrefab_HDAdditionalLightData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyTo_Public_Static_Void_HDAdditionalLightData_ProxyLightPrefab_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(4981)]
    [CachedScanResults(RefRangeStart = 10610, RefRangeEnd = 15591, XrefRangeStart = 10610, XrefRangeEnd = 15591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.Object System_ICloneable_Clone()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProxyLightPrefab.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111781, XrefRangeEnd = 1111794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ProxyLightPrefab CopyFrom(HDAdditionalLightData light)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) light);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProxyLightPrefab.NativeMethodInfoPtr_CopyFrom_Public_Static_ProxyLightPrefab_HDAdditionalLightData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (ProxyLightPrefab) null : new ProxyLightPrefab(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1111810, RefRangeEnd = 1111811, XrefRangeStart = 1111794, XrefRangeEnd = 1111810, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CopyTo(HDAdditionalLightData light, ProxyLightPrefab data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) light);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProxyLightPrefab.NativeMethodInfoPtr_CopyTo_Public_Static_Void_HDAdditionalLightData_ProxyLightPrefab_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProxyLightPrefab()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProxyLightPrefab>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProxyLightPrefab.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProxyLightPrefab()
    {
      Il2CppClassPointerStore<ProxyLightPrefab>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Presentation", nameof (ProxyLightPrefab));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProxyLightPrefab>.NativeClassPtr);
      ProxyLightPrefab.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyLightPrefab>.NativeClassPtr, nameof (color));
      ProxyLightPrefab.NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyLightPrefab>.NativeClassPtr, nameof (range));
      ProxyLightPrefab.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyLightPrefab>.NativeClassPtr, nameof (intensity));
      ProxyLightPrefab.NativeFieldInfoPtr_cookie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyLightPrefab>.NativeClassPtr, nameof (cookie));
      ProxyLightPrefab.NativeFieldInfoPtr_spotLightShape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyLightPrefab>.NativeClassPtr, nameof (spotLightShape));
      ProxyLightPrefab.NativeFieldInfoPtr_shapeRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyLightPrefab>.NativeClassPtr, nameof (shapeRadius));
      ProxyLightPrefab.NativeFieldInfoPtr_spotAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyLightPrefab>.NativeClassPtr, nameof (spotAngle));
      ProxyLightPrefab.NativeFieldInfoPtr_innerSpotPercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyLightPrefab>.NativeClassPtr, nameof (innerSpotPercent));
      ProxyLightPrefab.NativeFieldInfoPtr_aspectRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyLightPrefab>.NativeClassPtr, nameof (aspectRatio));
      ProxyLightPrefab.NativeFieldInfoPtr_shapeWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyLightPrefab>.NativeClassPtr, nameof (shapeWidth));
      ProxyLightPrefab.NativeFieldInfoPtr_shapeHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyLightPrefab>.NativeClassPtr, nameof (shapeHeight));
      ProxyLightPrefab.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyLightPrefab>.NativeClassPtr, nameof (type));
      ProxyLightPrefab.NativeFieldInfoPtr_DescriptionString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyLightPrefab>.NativeClassPtr, nameof (DescriptionString));
      ProxyLightPrefab.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyLightPrefab>.NativeClassPtr, 100687990);
      ProxyLightPrefab.NativeMethodInfoPtr_CopyFrom_Public_Static_ProxyLightPrefab_HDAdditionalLightData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyLightPrefab>.NativeClassPtr, 100687991);
      ProxyLightPrefab.NativeMethodInfoPtr_CopyTo_Public_Static_Void_HDAdditionalLightData_ProxyLightPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyLightPrefab>.NativeClassPtr, 100687992);
      ProxyLightPrefab.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyLightPrefab>.NativeClassPtr, 100687993);
    }

    public ProxyLightPrefab(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Color color
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProxyLightPrefab.NativeFieldInfoPtr_color));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProxyLightPrefab.NativeFieldInfoPtr_color)) = value;
      }
    }

    public unsafe float range
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProxyLightPrefab.NativeFieldInfoPtr_range));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProxyLightPrefab.NativeFieldInfoPtr_range)) = value;
      }
    }

    public unsafe float intensity
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProxyLightPrefab.NativeFieldInfoPtr_intensity));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProxyLightPrefab.NativeFieldInfoPtr_intensity)) = value;
      }
    }

    public unsafe Texture cookie
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProxyLightPrefab.NativeFieldInfoPtr_cookie));
        return pointer == System.IntPtr.Zero ? (Texture) null : new Texture(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ProxyLightPrefab.NativeFieldInfoPtr_cookie), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpotLightShape spotLightShape
    {
      get
      {
        return *(SpotLightShape*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProxyLightPrefab.NativeFieldInfoPtr_spotLightShape));
      }
      [param: In] set
      {
        *(SpotLightShape*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProxyLightPrefab.NativeFieldInfoPtr_spotLightShape)) = value;
      }
    }

    public unsafe float shapeRadius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProxyLightPrefab.NativeFieldInfoPtr_shapeRadius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProxyLightPrefab.NativeFieldInfoPtr_shapeRadius)) = value;
      }
    }

    public unsafe float spotAngle
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProxyLightPrefab.NativeFieldInfoPtr_spotAngle));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProxyLightPrefab.NativeFieldInfoPtr_spotAngle)) = value;
      }
    }

    public unsafe float innerSpotPercent
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProxyLightPrefab.NativeFieldInfoPtr_innerSpotPercent));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProxyLightPrefab.NativeFieldInfoPtr_innerSpotPercent)) = value;
      }
    }

    public unsafe float aspectRatio
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProxyLightPrefab.NativeFieldInfoPtr_aspectRatio));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProxyLightPrefab.NativeFieldInfoPtr_aspectRatio)) = value;
      }
    }

    public unsafe float shapeWidth
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProxyLightPrefab.NativeFieldInfoPtr_shapeWidth));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProxyLightPrefab.NativeFieldInfoPtr_shapeWidth)) = value;
      }
    }

    public unsafe float shapeHeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProxyLightPrefab.NativeFieldInfoPtr_shapeHeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProxyLightPrefab.NativeFieldInfoPtr_shapeHeight)) = value;
      }
    }

    public unsafe HDLightType type
    {
      get
      {
        return *(HDLightType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProxyLightPrefab.NativeFieldInfoPtr_type));
      }
      [param: In] set
      {
        *(HDLightType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProxyLightPrefab.NativeFieldInfoPtr_type)) = value;
      }
    }

    public static unsafe string DescriptionString
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(ProxyLightPrefab.NativeFieldInfoPtr_DescriptionString, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ProxyLightPrefab.NativeFieldInfoPtr_DescriptionString, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
