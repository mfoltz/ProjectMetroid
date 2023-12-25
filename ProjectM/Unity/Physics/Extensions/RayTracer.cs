// Decompiled with JetBrains decompiler
// Type: Unity.Physics.Extensions.RayTracer
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
namespace Unity.Physics.Extensions
{
  public class RayTracer : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_imageDisplay;
    private static readonly IntPtr NativeFieldInfoPtr_blasterMaterial;
    private static readonly IntPtr NativeFieldInfoPtr_blasterTexture;
    private static readonly IntPtr NativeFieldInfoPtr_AlternateKeys;
    private static readonly IntPtr NativeFieldInfoPtr_CastSphere;
    private static readonly IntPtr NativeFieldInfoPtr_Shadows;
    private static readonly IntPtr NativeFieldInfoPtr_ImagePlane;
    private static readonly IntPtr NativeFieldInfoPtr_RayLength;
    private static readonly IntPtr NativeFieldInfoPtr_AmbientLight;
    private static readonly IntPtr NativeFieldInfoPtr_DisplayTarget;
    private static readonly IntPtr NativeFieldInfoPtr_ImageRes;
    private static readonly IntPtr NativeFieldInfoPtr_planeHalfExtents;
    private static readonly IntPtr NativeFieldInfoPtr_lastResults;
    private static readonly IntPtr NativeFieldInfoPtr_ExpectingResults;
    private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926409, XrefRangeEnd = 926410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RayTracer.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926410, XrefRangeEnd = 926464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Start()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RayTracer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926464, XrefRangeEnd = 926536, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RayTracer.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926536, XrefRangeEnd = 926537, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RayTracer()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RayTracer>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RayTracer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RayTracer()
    {
      Il2CppClassPointerStore<RayTracer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Physics.Extensions", nameof (RayTracer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RayTracer>.NativeClassPtr);
      RayTracer.NativeFieldInfoPtr_imageDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayTracer>.NativeClassPtr, nameof (imageDisplay));
      RayTracer.NativeFieldInfoPtr_blasterMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayTracer>.NativeClassPtr, nameof (blasterMaterial));
      RayTracer.NativeFieldInfoPtr_blasterTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayTracer>.NativeClassPtr, nameof (blasterTexture));
      RayTracer.NativeFieldInfoPtr_AlternateKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayTracer>.NativeClassPtr, nameof (AlternateKeys));
      RayTracer.NativeFieldInfoPtr_CastSphere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayTracer>.NativeClassPtr, nameof (CastSphere));
      RayTracer.NativeFieldInfoPtr_Shadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayTracer>.NativeClassPtr, nameof (Shadows));
      RayTracer.NativeFieldInfoPtr_ImagePlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayTracer>.NativeClassPtr, nameof (ImagePlane));
      RayTracer.NativeFieldInfoPtr_RayLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayTracer>.NativeClassPtr, nameof (RayLength));
      RayTracer.NativeFieldInfoPtr_AmbientLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayTracer>.NativeClassPtr, nameof (AmbientLight));
      RayTracer.NativeFieldInfoPtr_DisplayTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayTracer>.NativeClassPtr, nameof (DisplayTarget));
      RayTracer.NativeFieldInfoPtr_ImageRes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayTracer>.NativeClassPtr, nameof (ImageRes));
      RayTracer.NativeFieldInfoPtr_planeHalfExtents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayTracer>.NativeClassPtr, nameof (planeHalfExtents));
      RayTracer.NativeFieldInfoPtr_lastResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayTracer>.NativeClassPtr, nameof (lastResults));
      RayTracer.NativeFieldInfoPtr_ExpectingResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayTracer>.NativeClassPtr, nameof (ExpectingResults));
      RayTracer.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayTracer>.NativeClassPtr, 100664010);
      RayTracer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayTracer>.NativeClassPtr, 100664011);
      RayTracer.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayTracer>.NativeClassPtr, 100664012);
      RayTracer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayTracer>.NativeClassPtr, 100664013);
    }

    public RayTracer(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameObject imageDisplay
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RayTracer.NativeFieldInfoPtr_imageDisplay));
        return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RayTracer.NativeFieldInfoPtr_imageDisplay), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UnityEngine.Material blasterMaterial
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RayTracer.NativeFieldInfoPtr_blasterMaterial));
        return pointer == IntPtr.Zero ? (UnityEngine.Material) null : new UnityEngine.Material(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RayTracer.NativeFieldInfoPtr_blasterMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Texture2D blasterTexture
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RayTracer.NativeFieldInfoPtr_blasterTexture));
        return pointer == IntPtr.Zero ? (Texture2D) null : new Texture2D(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RayTracer.NativeFieldInfoPtr_blasterTexture), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool AlternateKeys
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RayTracer.NativeFieldInfoPtr_AlternateKeys));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RayTracer.NativeFieldInfoPtr_AlternateKeys)) = value;
      }
    }

    public unsafe bool CastSphere
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RayTracer.NativeFieldInfoPtr_CastSphere));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RayTracer.NativeFieldInfoPtr_CastSphere)) = value;
      }
    }

    public unsafe bool Shadows
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RayTracer.NativeFieldInfoPtr_Shadows));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RayTracer.NativeFieldInfoPtr_Shadows)) = value;
      }
    }

    public unsafe float ImagePlane
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RayTracer.NativeFieldInfoPtr_ImagePlane));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RayTracer.NativeFieldInfoPtr_ImagePlane)) = value;
      }
    }

    public unsafe float RayLength
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RayTracer.NativeFieldInfoPtr_RayLength));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RayTracer.NativeFieldInfoPtr_RayLength)) = value;
      }
    }

    public unsafe float AmbientLight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RayTracer.NativeFieldInfoPtr_AmbientLight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RayTracer.NativeFieldInfoPtr_AmbientLight)) = value;
      }
    }

    public unsafe GameObject DisplayTarget
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RayTracer.NativeFieldInfoPtr_DisplayTarget));
        return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RayTracer.NativeFieldInfoPtr_DisplayTarget), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int ImageRes
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RayTracer.NativeFieldInfoPtr_ImageRes));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RayTracer.NativeFieldInfoPtr_ImageRes)) = value;
      }
    }

    public unsafe float planeHalfExtents
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RayTracer.NativeFieldInfoPtr_planeHalfExtents));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RayTracer.NativeFieldInfoPtr_planeHalfExtents)) = value;
      }
    }

    public unsafe RayTracerSystem.RayResult lastResults
    {
      get
      {
        return *(RayTracerSystem.RayResult*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RayTracer.NativeFieldInfoPtr_lastResults));
      }
      [param: In] set
      {
        *(RayTracerSystem.RayResult*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RayTracer.NativeFieldInfoPtr_lastResults)) = value;
      }
    }

    public unsafe bool ExpectingResults
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RayTracer.NativeFieldInfoPtr_ExpectingResults));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RayTracer.NativeFieldInfoPtr_ExpectingResults)) = value;
      }
    }
  }
}
