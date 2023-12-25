// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.MaterialPool
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Sequencer
{
  public class MaterialPool : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BaseColorTint;
    private static readonly System.IntPtr NativeFieldInfoPtr_BaseColorMap;
    private static readonly System.IntPtr NativeFieldInfoPtr_NormalMap;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaskMap;
    private static readonly System.IntPtr NativeFieldInfoPtr_Metallic;
    private static readonly System.IntPtr NativeFieldInfoPtr_Smoothness;
    private static readonly System.IntPtr NativeFieldInfoPtr_NormalStrength;
    private static readonly System.IntPtr NativeFieldInfoPtr_TrimNormalStrength;
    private static readonly System.IntPtr NativeFieldInfoPtr_BaseColorTint1;
    private static readonly System.IntPtr NativeFieldInfoPtr_BaseColorTint2;
    private static readonly System.IntPtr NativeFieldInfoPtr_BaseColorTint3;
    private static readonly System.IntPtr NativeFieldInfoPtr_BaseColorTrim1;
    private static readonly System.IntPtr NativeFieldInfoPtr_BaseColorTrim2;
    private static readonly System.IntPtr NativeFieldInfoPtr_BaseColorTrim3;
    private static readonly System.IntPtr NativeFieldInfoPtr_NormalTrim1;
    private static readonly System.IntPtr NativeFieldInfoPtr_NormalTrim2;
    private static readonly System.IntPtr NativeFieldInfoPtr_NormalTrim3;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaskTrim1;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaskTrim2;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaskTrim3;
    private static readonly System.IntPtr NativeFieldInfoPtr_MetallicTrim1;
    private static readonly System.IntPtr NativeFieldInfoPtr_MetallicTrim2;
    private static readonly System.IntPtr NativeFieldInfoPtr_MetallicTrim3;
    private static readonly System.IntPtr NativeFieldInfoPtr_SmoothnessTrim1;
    private static readonly System.IntPtr NativeFieldInfoPtr_SmoothnessTrim2;
    private static readonly System.IntPtr NativeFieldInfoPtr_SmoothnessTrim3;
    private static readonly System.IntPtr NativeFieldInfoPtr__MaterialPool;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMaterialCopy_Public_Material_Material_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReturnMaterial_Public_Void_Material_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyPatternToUdim_Public_Static_Void_Material_Material_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetUDIMPropIndices_Public_Static_UDIMProps_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyNormalMap_Public_Static_Void_Material_Material_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyBaseMap_Public_Static_Void_Material_Material_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Public_Void_0;

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1099227, RefRangeEnd = 1099233, XrefRangeStart = 1099219, XrefRangeEnd = 1099227, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MaterialPool()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MaterialPool.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 1099237, RefRangeEnd = 1099245, XrefRangeStart = 1099233, XrefRangeEnd = 1099237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Material GetMaterialCopy(Material sourceMaterial)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sourceMaterial);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MaterialPool.NativeMethodInfoPtr_GetMaterialCopy_Public_Material_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Material) null : new Material(pointer);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1099354, RefRangeEnd = 1099360, XrefRangeStart = 1099245, XrefRangeEnd = 1099354, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ReturnMaterial(Material material)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) material);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MaterialPool.NativeMethodInfoPtr_ReturnMaterial_Public_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1099591, RefRangeEnd = 1099597, XrefRangeStart = 1099360, XrefRangeEnd = 1099591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CopyPatternToUdim(Material pattern, Material udimMat, int udimIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pattern);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) udimMat);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &udimIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MaterialPool.NativeMethodInfoPtr_CopyPatternToUdim_Public_Static_Void_Material_Material_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099597, XrefRangeEnd = 1099609, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe MaterialPool.UDIMProps GetUDIMPropIndices(int udimIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &udimIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MaterialPool.NativeMethodInfoPtr_GetUDIMPropIndices_Public_Static_UDIMProps_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(MaterialPool.UDIMProps*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1099623, RefRangeEnd = 1099627, XrefRangeStart = 1099609, XrefRangeEnd = 1099623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CopyNormalMap(Material source, Material destination)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) destination);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MaterialPool.NativeMethodInfoPtr_CopyNormalMap_Public_Static_Void_Material_Material_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1099641, RefRangeEnd = 1099645, XrefRangeStart = 1099627, XrefRangeEnd = 1099641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CopyBaseMap(Material source, Material destination)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) destination);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MaterialPool.NativeMethodInfoPtr_CopyBaseMap_Public_Static_Void_Material_Material_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1099654, RefRangeEnd = 1099658, XrefRangeStart = 1099645, XrefRangeEnd = 1099654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Cleanup()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MaterialPool.NativeMethodInfoPtr_Cleanup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MaterialPool()
    {
      Il2CppClassPointerStore<MaterialPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (MaterialPool));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr);
      MaterialPool.NativeFieldInfoPtr_BaseColorTint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, nameof (BaseColorTint));
      MaterialPool.NativeFieldInfoPtr_BaseColorMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, nameof (BaseColorMap));
      MaterialPool.NativeFieldInfoPtr_NormalMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, nameof (NormalMap));
      MaterialPool.NativeFieldInfoPtr_MaskMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, nameof (MaskMap));
      MaterialPool.NativeFieldInfoPtr_Metallic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, nameof (Metallic));
      MaterialPool.NativeFieldInfoPtr_Smoothness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, nameof (Smoothness));
      MaterialPool.NativeFieldInfoPtr_NormalStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, nameof (NormalStrength));
      MaterialPool.NativeFieldInfoPtr_TrimNormalStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, nameof (TrimNormalStrength));
      MaterialPool.NativeFieldInfoPtr_BaseColorTint1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, nameof (BaseColorTint1));
      MaterialPool.NativeFieldInfoPtr_BaseColorTint2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, nameof (BaseColorTint2));
      MaterialPool.NativeFieldInfoPtr_BaseColorTint3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, nameof (BaseColorTint3));
      MaterialPool.NativeFieldInfoPtr_BaseColorTrim1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, nameof (BaseColorTrim1));
      MaterialPool.NativeFieldInfoPtr_BaseColorTrim2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, nameof (BaseColorTrim2));
      MaterialPool.NativeFieldInfoPtr_BaseColorTrim3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, nameof (BaseColorTrim3));
      MaterialPool.NativeFieldInfoPtr_NormalTrim1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, nameof (NormalTrim1));
      MaterialPool.NativeFieldInfoPtr_NormalTrim2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, nameof (NormalTrim2));
      MaterialPool.NativeFieldInfoPtr_NormalTrim3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, nameof (NormalTrim3));
      MaterialPool.NativeFieldInfoPtr_MaskTrim1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, nameof (MaskTrim1));
      MaterialPool.NativeFieldInfoPtr_MaskTrim2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, nameof (MaskTrim2));
      MaterialPool.NativeFieldInfoPtr_MaskTrim3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, nameof (MaskTrim3));
      MaterialPool.NativeFieldInfoPtr_MetallicTrim1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, nameof (MetallicTrim1));
      MaterialPool.NativeFieldInfoPtr_MetallicTrim2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, nameof (MetallicTrim2));
      MaterialPool.NativeFieldInfoPtr_MetallicTrim3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, nameof (MetallicTrim3));
      MaterialPool.NativeFieldInfoPtr_SmoothnessTrim1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, nameof (SmoothnessTrim1));
      MaterialPool.NativeFieldInfoPtr_SmoothnessTrim2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, nameof (SmoothnessTrim2));
      MaterialPool.NativeFieldInfoPtr_SmoothnessTrim3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, nameof (SmoothnessTrim3));
      MaterialPool.NativeFieldInfoPtr__MaterialPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, nameof (_MaterialPool));
      MaterialPool.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, 100687283);
      MaterialPool.NativeMethodInfoPtr_GetMaterialCopy_Public_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, 100687284);
      MaterialPool.NativeMethodInfoPtr_ReturnMaterial_Public_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, 100687285);
      MaterialPool.NativeMethodInfoPtr_CopyPatternToUdim_Public_Static_Void_Material_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, 100687286);
      MaterialPool.NativeMethodInfoPtr_GetUDIMPropIndices_Public_Static_UDIMProps_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, 100687287);
      MaterialPool.NativeMethodInfoPtr_CopyNormalMap_Public_Static_Void_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, 100687288);
      MaterialPool.NativeMethodInfoPtr_CopyBaseMap_Public_Static_Void_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, 100687289);
      MaterialPool.NativeMethodInfoPtr_Cleanup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, 100687290);
    }

    public MaterialPool(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int BaseColorTint
    {
      get
      {
        int baseColorTint;
        IL2CPP.il2cpp_field_static_get_value(MaterialPool.NativeFieldInfoPtr_BaseColorTint, (void*) &baseColorTint);
        return baseColorTint;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MaterialPool.NativeFieldInfoPtr_BaseColorTint, (void*) &value);
      }
    }

    public static unsafe int BaseColorMap
    {
      get
      {
        int baseColorMap;
        IL2CPP.il2cpp_field_static_get_value(MaterialPool.NativeFieldInfoPtr_BaseColorMap, (void*) &baseColorMap);
        return baseColorMap;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MaterialPool.NativeFieldInfoPtr_BaseColorMap, (void*) &value);
      }
    }

    public static unsafe int NormalMap
    {
      get
      {
        int normalMap;
        IL2CPP.il2cpp_field_static_get_value(MaterialPool.NativeFieldInfoPtr_NormalMap, (void*) &normalMap);
        return normalMap;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MaterialPool.NativeFieldInfoPtr_NormalMap, (void*) &value);
      }
    }

    public static unsafe int MaskMap
    {
      get
      {
        int maskMap;
        IL2CPP.il2cpp_field_static_get_value(MaterialPool.NativeFieldInfoPtr_MaskMap, (void*) &maskMap);
        return maskMap;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MaterialPool.NativeFieldInfoPtr_MaskMap, (void*) &value);
      }
    }

    public static unsafe int Metallic
    {
      get
      {
        int metallic;
        IL2CPP.il2cpp_field_static_get_value(MaterialPool.NativeFieldInfoPtr_Metallic, (void*) &metallic);
        return metallic;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MaterialPool.NativeFieldInfoPtr_Metallic, (void*) &value);
      }
    }

    public static unsafe int Smoothness
    {
      get
      {
        int smoothness;
        IL2CPP.il2cpp_field_static_get_value(MaterialPool.NativeFieldInfoPtr_Smoothness, (void*) &smoothness);
        return smoothness;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MaterialPool.NativeFieldInfoPtr_Smoothness, (void*) &value);
      }
    }

    public static unsafe int NormalStrength
    {
      get
      {
        int normalStrength;
        IL2CPP.il2cpp_field_static_get_value(MaterialPool.NativeFieldInfoPtr_NormalStrength, (void*) &normalStrength);
        return normalStrength;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MaterialPool.NativeFieldInfoPtr_NormalStrength, (void*) &value);
      }
    }

    public static unsafe int TrimNormalStrength
    {
      get
      {
        int trimNormalStrength;
        IL2CPP.il2cpp_field_static_get_value(MaterialPool.NativeFieldInfoPtr_TrimNormalStrength, (void*) &trimNormalStrength);
        return trimNormalStrength;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MaterialPool.NativeFieldInfoPtr_TrimNormalStrength, (void*) &value);
      }
    }

    public static unsafe int BaseColorTint1
    {
      get
      {
        int baseColorTint1;
        IL2CPP.il2cpp_field_static_get_value(MaterialPool.NativeFieldInfoPtr_BaseColorTint1, (void*) &baseColorTint1);
        return baseColorTint1;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MaterialPool.NativeFieldInfoPtr_BaseColorTint1, (void*) &value);
      }
    }

    public static unsafe int BaseColorTint2
    {
      get
      {
        int baseColorTint2;
        IL2CPP.il2cpp_field_static_get_value(MaterialPool.NativeFieldInfoPtr_BaseColorTint2, (void*) &baseColorTint2);
        return baseColorTint2;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MaterialPool.NativeFieldInfoPtr_BaseColorTint2, (void*) &value);
      }
    }

    public static unsafe int BaseColorTint3
    {
      get
      {
        int baseColorTint3;
        IL2CPP.il2cpp_field_static_get_value(MaterialPool.NativeFieldInfoPtr_BaseColorTint3, (void*) &baseColorTint3);
        return baseColorTint3;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MaterialPool.NativeFieldInfoPtr_BaseColorTint3, (void*) &value);
      }
    }

    public static unsafe int BaseColorTrim1
    {
      get
      {
        int baseColorTrim1;
        IL2CPP.il2cpp_field_static_get_value(MaterialPool.NativeFieldInfoPtr_BaseColorTrim1, (void*) &baseColorTrim1);
        return baseColorTrim1;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MaterialPool.NativeFieldInfoPtr_BaseColorTrim1, (void*) &value);
      }
    }

    public static unsafe int BaseColorTrim2
    {
      get
      {
        int baseColorTrim2;
        IL2CPP.il2cpp_field_static_get_value(MaterialPool.NativeFieldInfoPtr_BaseColorTrim2, (void*) &baseColorTrim2);
        return baseColorTrim2;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MaterialPool.NativeFieldInfoPtr_BaseColorTrim2, (void*) &value);
      }
    }

    public static unsafe int BaseColorTrim3
    {
      get
      {
        int baseColorTrim3;
        IL2CPP.il2cpp_field_static_get_value(MaterialPool.NativeFieldInfoPtr_BaseColorTrim3, (void*) &baseColorTrim3);
        return baseColorTrim3;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MaterialPool.NativeFieldInfoPtr_BaseColorTrim3, (void*) &value);
      }
    }

    public static unsafe int NormalTrim1
    {
      get
      {
        int normalTrim1;
        IL2CPP.il2cpp_field_static_get_value(MaterialPool.NativeFieldInfoPtr_NormalTrim1, (void*) &normalTrim1);
        return normalTrim1;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MaterialPool.NativeFieldInfoPtr_NormalTrim1, (void*) &value);
      }
    }

    public static unsafe int NormalTrim2
    {
      get
      {
        int normalTrim2;
        IL2CPP.il2cpp_field_static_get_value(MaterialPool.NativeFieldInfoPtr_NormalTrim2, (void*) &normalTrim2);
        return normalTrim2;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MaterialPool.NativeFieldInfoPtr_NormalTrim2, (void*) &value);
      }
    }

    public static unsafe int NormalTrim3
    {
      get
      {
        int normalTrim3;
        IL2CPP.il2cpp_field_static_get_value(MaterialPool.NativeFieldInfoPtr_NormalTrim3, (void*) &normalTrim3);
        return normalTrim3;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MaterialPool.NativeFieldInfoPtr_NormalTrim3, (void*) &value);
      }
    }

    public static unsafe int MaskTrim1
    {
      get
      {
        int maskTrim1;
        IL2CPP.il2cpp_field_static_get_value(MaterialPool.NativeFieldInfoPtr_MaskTrim1, (void*) &maskTrim1);
        return maskTrim1;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MaterialPool.NativeFieldInfoPtr_MaskTrim1, (void*) &value);
      }
    }

    public static unsafe int MaskTrim2
    {
      get
      {
        int maskTrim2;
        IL2CPP.il2cpp_field_static_get_value(MaterialPool.NativeFieldInfoPtr_MaskTrim2, (void*) &maskTrim2);
        return maskTrim2;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MaterialPool.NativeFieldInfoPtr_MaskTrim2, (void*) &value);
      }
    }

    public static unsafe int MaskTrim3
    {
      get
      {
        int maskTrim3;
        IL2CPP.il2cpp_field_static_get_value(MaterialPool.NativeFieldInfoPtr_MaskTrim3, (void*) &maskTrim3);
        return maskTrim3;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MaterialPool.NativeFieldInfoPtr_MaskTrim3, (void*) &value);
      }
    }

    public static unsafe int MetallicTrim1
    {
      get
      {
        int metallicTrim1;
        IL2CPP.il2cpp_field_static_get_value(MaterialPool.NativeFieldInfoPtr_MetallicTrim1, (void*) &metallicTrim1);
        return metallicTrim1;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MaterialPool.NativeFieldInfoPtr_MetallicTrim1, (void*) &value);
      }
    }

    public static unsafe int MetallicTrim2
    {
      get
      {
        int metallicTrim2;
        IL2CPP.il2cpp_field_static_get_value(MaterialPool.NativeFieldInfoPtr_MetallicTrim2, (void*) &metallicTrim2);
        return metallicTrim2;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MaterialPool.NativeFieldInfoPtr_MetallicTrim2, (void*) &value);
      }
    }

    public static unsafe int MetallicTrim3
    {
      get
      {
        int metallicTrim3;
        IL2CPP.il2cpp_field_static_get_value(MaterialPool.NativeFieldInfoPtr_MetallicTrim3, (void*) &metallicTrim3);
        return metallicTrim3;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MaterialPool.NativeFieldInfoPtr_MetallicTrim3, (void*) &value);
      }
    }

    public static unsafe int SmoothnessTrim1
    {
      get
      {
        int smoothnessTrim1;
        IL2CPP.il2cpp_field_static_get_value(MaterialPool.NativeFieldInfoPtr_SmoothnessTrim1, (void*) &smoothnessTrim1);
        return smoothnessTrim1;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MaterialPool.NativeFieldInfoPtr_SmoothnessTrim1, (void*) &value);
      }
    }

    public static unsafe int SmoothnessTrim2
    {
      get
      {
        int smoothnessTrim2;
        IL2CPP.il2cpp_field_static_get_value(MaterialPool.NativeFieldInfoPtr_SmoothnessTrim2, (void*) &smoothnessTrim2);
        return smoothnessTrim2;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MaterialPool.NativeFieldInfoPtr_SmoothnessTrim2, (void*) &value);
      }
    }

    public static unsafe int SmoothnessTrim3
    {
      get
      {
        int smoothnessTrim3;
        IL2CPP.il2cpp_field_static_get_value(MaterialPool.NativeFieldInfoPtr_SmoothnessTrim3, (void*) &smoothnessTrim3);
        return smoothnessTrim3;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MaterialPool.NativeFieldInfoPtr_SmoothnessTrim3, (void*) &value);
      }
    }

    public unsafe Stack<Material> _MaterialPool
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialPool.NativeFieldInfoPtr__MaterialPool));
        return pointer == System.IntPtr.Zero ? (Stack<Material>) null : new Stack<Material>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaterialPool.NativeFieldInfoPtr__MaterialPool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct UDIMProps
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_BaseMapID;
      private static readonly System.IntPtr NativeFieldInfoPtr_NormalMapID;
      private static readonly System.IntPtr NativeFieldInfoPtr_MaskMapID;
      private static readonly System.IntPtr NativeFieldInfoPtr_MetallicID;
      private static readonly System.IntPtr NativeFieldInfoPtr_SmoothnessID;
      [FieldOffset(0)]
      public int BaseMapID;
      [FieldOffset(4)]
      public int NormalMapID;
      [FieldOffset(8)]
      public int MaskMapID;
      [FieldOffset(12)]
      public int MetallicID;
      [FieldOffset(16)]
      public int SmoothnessID;

      static UDIMProps()
      {
        Il2CppClassPointerStore<MaterialPool.UDIMProps>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialPool>.NativeClassPtr, nameof (UDIMProps));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialPool.UDIMProps>.NativeClassPtr);
        MaterialPool.UDIMProps.NativeFieldInfoPtr_BaseMapID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPool.UDIMProps>.NativeClassPtr, nameof (BaseMapID));
        MaterialPool.UDIMProps.NativeFieldInfoPtr_NormalMapID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPool.UDIMProps>.NativeClassPtr, nameof (NormalMapID));
        MaterialPool.UDIMProps.NativeFieldInfoPtr_MaskMapID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPool.UDIMProps>.NativeClassPtr, nameof (MaskMapID));
        MaterialPool.UDIMProps.NativeFieldInfoPtr_MetallicID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPool.UDIMProps>.NativeClassPtr, nameof (MetallicID));
        MaterialPool.UDIMProps.NativeFieldInfoPtr_SmoothnessID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPool.UDIMProps>.NativeClassPtr, nameof (SmoothnessID));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MaterialPool.UDIMProps>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
