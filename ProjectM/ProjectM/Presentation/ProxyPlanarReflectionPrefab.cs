// Decompiled with JetBrains decompiler
// Type: ProjectM.Presentation.ProxyPlanarReflectionPrefab
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
  public class ProxyPlanarReflectionPrefab : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_InfluenceVolume;
    private static readonly System.IntPtr NativeFieldInfoPtr_DescriptionString;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyFrom_Public_Static_ProxyPlanarReflectionPrefab_PlanarReflectionProbe_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyTo_Public_Static_Void_PlanarReflectionProbe_ProxyPlanarReflectionPrefab_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111843, XrefRangeEnd = 1111849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ProxyPlanarReflectionPrefab CopyFrom(PlanarReflectionProbe probe)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) probe);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProxyPlanarReflectionPrefab.NativeMethodInfoPtr_CopyFrom_Public_Static_ProxyPlanarReflectionPrefab_PlanarReflectionProbe_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (ProxyPlanarReflectionPrefab) null : new ProxyPlanarReflectionPrefab(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1111851, RefRangeEnd = 1111852, XrefRangeStart = 1111849, XrefRangeEnd = 1111851, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CopyTo(PlanarReflectionProbe probe, ProxyPlanarReflectionPrefab data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) probe);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProxyPlanarReflectionPrefab.NativeMethodInfoPtr_CopyTo_Public_Static_Void_PlanarReflectionProbe_ProxyPlanarReflectionPrefab_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4981)]
    [CachedScanResults(RefRangeStart = 10610, RefRangeEnd = 15591, XrefRangeStart = 10610, XrefRangeEnd = 15591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.Object System_ICloneable_Clone()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProxyPlanarReflectionPrefab.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProxyPlanarReflectionPrefab()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProxyPlanarReflectionPrefab>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProxyPlanarReflectionPrefab.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProxyPlanarReflectionPrefab()
    {
      Il2CppClassPointerStore<ProxyPlanarReflectionPrefab>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Presentation", nameof (ProxyPlanarReflectionPrefab));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProxyPlanarReflectionPrefab>.NativeClassPtr);
      ProxyPlanarReflectionPrefab.NativeFieldInfoPtr_InfluenceVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyPlanarReflectionPrefab>.NativeClassPtr, nameof (InfluenceVolume));
      ProxyPlanarReflectionPrefab.NativeFieldInfoPtr_DescriptionString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyPlanarReflectionPrefab>.NativeClassPtr, nameof (DescriptionString));
      ProxyPlanarReflectionPrefab.NativeMethodInfoPtr_CopyFrom_Public_Static_ProxyPlanarReflectionPrefab_PlanarReflectionProbe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyPlanarReflectionPrefab>.NativeClassPtr, 100687997);
      ProxyPlanarReflectionPrefab.NativeMethodInfoPtr_CopyTo_Public_Static_Void_PlanarReflectionProbe_ProxyPlanarReflectionPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyPlanarReflectionPrefab>.NativeClassPtr, 100687998);
      ProxyPlanarReflectionPrefab.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyPlanarReflectionPrefab>.NativeClassPtr, 100687999);
      ProxyPlanarReflectionPrefab.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyPlanarReflectionPrefab>.NativeClassPtr, 100688000);
    }

    public ProxyPlanarReflectionPrefab(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ProxyPlanarReflectionPrefab.InfluenceVolumeData InfluenceVolume
    {
      get
      {
        return *(ProxyPlanarReflectionPrefab.InfluenceVolumeData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProxyPlanarReflectionPrefab.NativeFieldInfoPtr_InfluenceVolume));
      }
      [param: In] set
      {
        *(ProxyPlanarReflectionPrefab.InfluenceVolumeData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProxyPlanarReflectionPrefab.NativeFieldInfoPtr_InfluenceVolume)) = value;
      }
    }

    public static unsafe string DescriptionString
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(ProxyPlanarReflectionPrefab.NativeFieldInfoPtr_DescriptionString, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ProxyPlanarReflectionPrefab.NativeFieldInfoPtr_DescriptionString, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct InfluenceVolumeData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_m_Shape;
      private static readonly System.IntPtr NativeFieldInfoPtr_m_BoxSize;
      private static readonly System.IntPtr NativeFieldInfoPtr_m_BoxBlendDistancePositive;
      private static readonly System.IntPtr NativeFieldInfoPtr_m_BoxBlendDistanceNegative;
      private static readonly System.IntPtr NativeFieldInfoPtr_m_BoxBlendNormalDistancePositive;
      private static readonly System.IntPtr NativeFieldInfoPtr_m_BoxBlendNormalDistanceNegative;
      private static readonly System.IntPtr NativeFieldInfoPtr_m_BoxSideFadePositive;
      private static readonly System.IntPtr NativeFieldInfoPtr_m_BoxSideFadeNegative;
      private static readonly System.IntPtr NativeFieldInfoPtr_m_SphereRadius;
      private static readonly System.IntPtr NativeFieldInfoPtr_m_SphereBlendDistance;
      private static readonly System.IntPtr NativeFieldInfoPtr_m_SphereBlendNormalDistance;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopyFrom_Public_Static_InfluenceVolumeData_InfluenceVolume_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopyTo_Public_Static_Void_InfluenceVolume_InfluenceVolumeData_0;
      [FieldOffset(0)]
      public InfluenceShape m_Shape;
      [FieldOffset(4)]
      public Vector3 m_BoxSize;
      [FieldOffset(16)]
      public Vector3 m_BoxBlendDistancePositive;
      [FieldOffset(28)]
      public Vector3 m_BoxBlendDistanceNegative;
      [FieldOffset(40)]
      public Vector3 m_BoxBlendNormalDistancePositive;
      [FieldOffset(52)]
      public Vector3 m_BoxBlendNormalDistanceNegative;
      [FieldOffset(64)]
      public Vector3 m_BoxSideFadePositive;
      [FieldOffset(76)]
      public Vector3 m_BoxSideFadeNegative;
      [FieldOffset(88)]
      public float m_SphereRadius;
      [FieldOffset(92)]
      public float m_SphereBlendDistance;
      [FieldOffset(96)]
      public float m_SphereBlendNormalDistance;

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1111840, RefRangeEnd = 1111842, XrefRangeStart = 1111840, XrefRangeEnd = 1111840, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe ProxyPlanarReflectionPrefab.InfluenceVolumeData CopyFrom(
        UnityEngine.Rendering.HighDefinition.InfluenceVolume influenceVolume)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) influenceVolume);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProxyPlanarReflectionPrefab.InfluenceVolumeData.NativeMethodInfoPtr_CopyFrom_Public_Static_InfluenceVolumeData_InfluenceVolume_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ProxyPlanarReflectionPrefab.InfluenceVolumeData*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1111842, RefRangeEnd = 1111843, XrefRangeStart = 1111842, XrefRangeEnd = 1111842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void CopyTo(
        UnityEngine.Rendering.HighDefinition.InfluenceVolume influenceVolume,
        ProxyPlanarReflectionPrefab.InfluenceVolumeData data)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) influenceVolume);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &data;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProxyPlanarReflectionPrefab.InfluenceVolumeData.NativeMethodInfoPtr_CopyTo_Public_Static_Void_InfluenceVolume_InfluenceVolumeData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static InfluenceVolumeData()
      {
        Il2CppClassPointerStore<ProxyPlanarReflectionPrefab.InfluenceVolumeData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProxyPlanarReflectionPrefab>.NativeClassPtr, nameof (InfluenceVolumeData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProxyPlanarReflectionPrefab.InfluenceVolumeData>.NativeClassPtr);
        ProxyPlanarReflectionPrefab.InfluenceVolumeData.NativeFieldInfoPtr_m_Shape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyPlanarReflectionPrefab.InfluenceVolumeData>.NativeClassPtr, nameof (m_Shape));
        ProxyPlanarReflectionPrefab.InfluenceVolumeData.NativeFieldInfoPtr_m_BoxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyPlanarReflectionPrefab.InfluenceVolumeData>.NativeClassPtr, nameof (m_BoxSize));
        ProxyPlanarReflectionPrefab.InfluenceVolumeData.NativeFieldInfoPtr_m_BoxBlendDistancePositive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyPlanarReflectionPrefab.InfluenceVolumeData>.NativeClassPtr, nameof (m_BoxBlendDistancePositive));
        ProxyPlanarReflectionPrefab.InfluenceVolumeData.NativeFieldInfoPtr_m_BoxBlendDistanceNegative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyPlanarReflectionPrefab.InfluenceVolumeData>.NativeClassPtr, nameof (m_BoxBlendDistanceNegative));
        ProxyPlanarReflectionPrefab.InfluenceVolumeData.NativeFieldInfoPtr_m_BoxBlendNormalDistancePositive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyPlanarReflectionPrefab.InfluenceVolumeData>.NativeClassPtr, nameof (m_BoxBlendNormalDistancePositive));
        ProxyPlanarReflectionPrefab.InfluenceVolumeData.NativeFieldInfoPtr_m_BoxBlendNormalDistanceNegative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyPlanarReflectionPrefab.InfluenceVolumeData>.NativeClassPtr, nameof (m_BoxBlendNormalDistanceNegative));
        ProxyPlanarReflectionPrefab.InfluenceVolumeData.NativeFieldInfoPtr_m_BoxSideFadePositive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyPlanarReflectionPrefab.InfluenceVolumeData>.NativeClassPtr, nameof (m_BoxSideFadePositive));
        ProxyPlanarReflectionPrefab.InfluenceVolumeData.NativeFieldInfoPtr_m_BoxSideFadeNegative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyPlanarReflectionPrefab.InfluenceVolumeData>.NativeClassPtr, nameof (m_BoxSideFadeNegative));
        ProxyPlanarReflectionPrefab.InfluenceVolumeData.NativeFieldInfoPtr_m_SphereRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyPlanarReflectionPrefab.InfluenceVolumeData>.NativeClassPtr, nameof (m_SphereRadius));
        ProxyPlanarReflectionPrefab.InfluenceVolumeData.NativeFieldInfoPtr_m_SphereBlendDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyPlanarReflectionPrefab.InfluenceVolumeData>.NativeClassPtr, nameof (m_SphereBlendDistance));
        ProxyPlanarReflectionPrefab.InfluenceVolumeData.NativeFieldInfoPtr_m_SphereBlendNormalDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyPlanarReflectionPrefab.InfluenceVolumeData>.NativeClassPtr, nameof (m_SphereBlendNormalDistance));
        ProxyPlanarReflectionPrefab.InfluenceVolumeData.NativeMethodInfoPtr_CopyFrom_Public_Static_InfluenceVolumeData_InfluenceVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyPlanarReflectionPrefab.InfluenceVolumeData>.NativeClassPtr, 100688001);
        ProxyPlanarReflectionPrefab.InfluenceVolumeData.NativeMethodInfoPtr_CopyTo_Public_Static_Void_InfluenceVolume_InfluenceVolumeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyPlanarReflectionPrefab.InfluenceVolumeData>.NativeClassPtr, 100688002);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProxyPlanarReflectionPrefab.InfluenceVolumeData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
