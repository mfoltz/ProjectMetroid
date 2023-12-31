// Decompiled with JetBrains decompiler
// Type: ProjectM.SplineAuthoring
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class SplineAuthoring : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SubSplines;
    private static readonly System.IntPtr NativeFieldInfoPtr_SplineNodes;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModuleCollection;
    private static readonly System.IntPtr NativeFieldInfoPtr_MeshGenSpecsAsset;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExistingGenMeshRef;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverrideMaterial;
    private static readonly System.IntPtr NativeFieldInfoPtr_SplineColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurveType;
    private static readonly System.IntPtr NativeFieldInfoPtr_DragPickMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_MeshGenerationMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModuleSizeModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_NodeGizmoSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsVisible;
    private static readonly System.IntPtr NativeFieldInfoPtr_LockSplineGeneration;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseStartModule;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseEndModule;
    private static readonly System.IntPtr NativeFieldInfoPtr_IndependentBezierPoints;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowSubSplines;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverrideModuleMaterial;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastShadows;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750332, XrefRangeEnd = 750347, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SplineAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SplineAuthoring>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SplineAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SplineAuthoring()
    {
      Il2CppClassPointerStore<SplineAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SplineAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SplineAuthoring>.NativeClassPtr);
      SplineAuthoring.NativeFieldInfoPtr_SubSplines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineAuthoring>.NativeClassPtr, nameof (SubSplines));
      SplineAuthoring.NativeFieldInfoPtr_SplineNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineAuthoring>.NativeClassPtr, nameof (SplineNodes));
      SplineAuthoring.NativeFieldInfoPtr_ModuleCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineAuthoring>.NativeClassPtr, nameof (ModuleCollection));
      SplineAuthoring.NativeFieldInfoPtr_MeshGenSpecsAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineAuthoring>.NativeClassPtr, nameof (MeshGenSpecsAsset));
      SplineAuthoring.NativeFieldInfoPtr_ExistingGenMeshRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineAuthoring>.NativeClassPtr, nameof (ExistingGenMeshRef));
      SplineAuthoring.NativeFieldInfoPtr_OverrideMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineAuthoring>.NativeClassPtr, nameof (OverrideMaterial));
      SplineAuthoring.NativeFieldInfoPtr_SplineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineAuthoring>.NativeClassPtr, nameof (SplineColor));
      SplineAuthoring.NativeFieldInfoPtr_CurveType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineAuthoring>.NativeClassPtr, nameof (CurveType));
      SplineAuthoring.NativeFieldInfoPtr_DragPickMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineAuthoring>.NativeClassPtr, nameof (DragPickMode));
      SplineAuthoring.NativeFieldInfoPtr_MeshGenerationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineAuthoring>.NativeClassPtr, nameof (MeshGenerationMode));
      SplineAuthoring.NativeFieldInfoPtr_ModuleSizeModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineAuthoring>.NativeClassPtr, nameof (ModuleSizeModifier));
      SplineAuthoring.NativeFieldInfoPtr_NodeGizmoSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineAuthoring>.NativeClassPtr, nameof (NodeGizmoSize));
      SplineAuthoring.NativeFieldInfoPtr_IsVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineAuthoring>.NativeClassPtr, nameof (IsVisible));
      SplineAuthoring.NativeFieldInfoPtr_LockSplineGeneration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineAuthoring>.NativeClassPtr, nameof (LockSplineGeneration));
      SplineAuthoring.NativeFieldInfoPtr_UseStartModule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineAuthoring>.NativeClassPtr, nameof (UseStartModule));
      SplineAuthoring.NativeFieldInfoPtr_UseEndModule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineAuthoring>.NativeClassPtr, nameof (UseEndModule));
      SplineAuthoring.NativeFieldInfoPtr_IndependentBezierPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineAuthoring>.NativeClassPtr, nameof (IndependentBezierPoints));
      SplineAuthoring.NativeFieldInfoPtr_ShowSubSplines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineAuthoring>.NativeClassPtr, nameof (ShowSubSplines));
      SplineAuthoring.NativeFieldInfoPtr_OverrideModuleMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineAuthoring>.NativeClassPtr, nameof (OverrideModuleMaterial));
      SplineAuthoring.NativeFieldInfoPtr_CastShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineAuthoring>.NativeClassPtr, nameof (CastShadows));
      SplineAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplineAuthoring>.NativeClassPtr, 100666048);
    }

    public SplineAuthoring(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<SplineAuthoring.SubSpline> SubSplines
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.NativeFieldInfoPtr_SubSplines));
        return pointer == System.IntPtr.Zero ? (List<SplineAuthoring.SubSpline>) null : new List<SplineAuthoring.SubSpline>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.NativeFieldInfoPtr_SubSplines), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<SplineAuthoring.SplineNode> SplineNodes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.NativeFieldInfoPtr_SplineNodes));
        return pointer == System.IntPtr.Zero ? (List<SplineAuthoring.SplineNode>) null : new List<SplineAuthoring.SplineNode>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.NativeFieldInfoPtr_SplineNodes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SplineModuleCollection ModuleCollection
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.NativeFieldInfoPtr_ModuleCollection));
        return pointer == System.IntPtr.Zero ? (SplineModuleCollection) null : new SplineModuleCollection(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.NativeFieldInfoPtr_ModuleCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SplineMeshGenSpecsAsset MeshGenSpecsAsset
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.NativeFieldInfoPtr_MeshGenSpecsAsset));
        return pointer == System.IntPtr.Zero ? (SplineMeshGenSpecsAsset) null : new SplineMeshGenSpecsAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.NativeFieldInfoPtr_MeshGenSpecsAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Mesh ExistingGenMeshRef
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.NativeFieldInfoPtr_ExistingGenMeshRef));
        return pointer == System.IntPtr.Zero ? (Mesh) null : new Mesh(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.NativeFieldInfoPtr_ExistingGenMeshRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Material OverrideMaterial
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.NativeFieldInfoPtr_OverrideMaterial));
        return pointer == System.IntPtr.Zero ? (Material) null : new Material(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.NativeFieldInfoPtr_OverrideMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Color SplineColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.NativeFieldInfoPtr_SplineColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.NativeFieldInfoPtr_SplineColor)) = value;
      }
    }

    public unsafe SplineAuthoring.SplineType CurveType
    {
      get
      {
        return *(SplineAuthoring.SplineType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.NativeFieldInfoPtr_CurveType));
      }
      [param: In] set
      {
        *(SplineAuthoring.SplineType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.NativeFieldInfoPtr_CurveType)) = value;
      }
    }

    public unsafe SplineAuthoring.FreeDragPickMode DragPickMode
    {
      get
      {
        return *(SplineAuthoring.FreeDragPickMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.NativeFieldInfoPtr_DragPickMode));
      }
      [param: In] set
      {
        *(SplineAuthoring.FreeDragPickMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.NativeFieldInfoPtr_DragPickMode)) = value;
      }
    }

    public unsafe SplineAuthoring.MeshGenMode MeshGenerationMode
    {
      get
      {
        return *(SplineAuthoring.MeshGenMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.NativeFieldInfoPtr_MeshGenerationMode));
      }
      [param: In] set
      {
        *(SplineAuthoring.MeshGenMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.NativeFieldInfoPtr_MeshGenerationMode)) = value;
      }
    }

    public unsafe float ModuleSizeModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.NativeFieldInfoPtr_ModuleSizeModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.NativeFieldInfoPtr_ModuleSizeModifier)) = value;
      }
    }

    public static unsafe float NodeGizmoSize
    {
      get
      {
        float nodeGizmoSize;
        IL2CPP.il2cpp_field_static_get_value(SplineAuthoring.NativeFieldInfoPtr_NodeGizmoSize, (void*) &nodeGizmoSize);
        return nodeGizmoSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SplineAuthoring.NativeFieldInfoPtr_NodeGizmoSize, (void*) &value);
      }
    }

    public unsafe bool IsVisible
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.NativeFieldInfoPtr_IsVisible));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.NativeFieldInfoPtr_IsVisible)) = value;
      }
    }

    public unsafe bool LockSplineGeneration
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.NativeFieldInfoPtr_LockSplineGeneration));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.NativeFieldInfoPtr_LockSplineGeneration)) = value;
      }
    }

    public unsafe bool UseStartModule
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.NativeFieldInfoPtr_UseStartModule));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.NativeFieldInfoPtr_UseStartModule)) = value;
      }
    }

    public unsafe bool UseEndModule
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.NativeFieldInfoPtr_UseEndModule));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.NativeFieldInfoPtr_UseEndModule)) = value;
      }
    }

    public unsafe bool IndependentBezierPoints
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.NativeFieldInfoPtr_IndependentBezierPoints));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.NativeFieldInfoPtr_IndependentBezierPoints)) = value;
      }
    }

    public unsafe bool ShowSubSplines
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.NativeFieldInfoPtr_ShowSubSplines));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.NativeFieldInfoPtr_ShowSubSplines)) = value;
      }
    }

    public unsafe bool OverrideModuleMaterial
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.NativeFieldInfoPtr_OverrideModuleMaterial));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.NativeFieldInfoPtr_OverrideModuleMaterial)) = value;
      }
    }

    public unsafe bool CastShadows
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.NativeFieldInfoPtr_CastShadows));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.NativeFieldInfoPtr_CastShadows)) = value;
      }
    }

    public enum SplineType
    {
      LinearModule,
      BezierModule,
      BezierMeshGen,
    }

    [Serializable]
    public class SplineNode : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Position;
      private static readonly System.IntPtr NativeFieldInfoPtr_Tangent1;
      private static readonly System.IntPtr NativeFieldInfoPtr_Tangent2;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsLocked;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe SplineNode()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SplineAuthoring.SplineNode>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SplineAuthoring.SplineNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static SplineNode()
      {
        Il2CppClassPointerStore<SplineAuthoring.SplineNode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SplineAuthoring>.NativeClassPtr, nameof (SplineNode));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SplineAuthoring.SplineNode>.NativeClassPtr);
        SplineAuthoring.SplineNode.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineAuthoring.SplineNode>.NativeClassPtr, nameof (Position));
        SplineAuthoring.SplineNode.NativeFieldInfoPtr_Tangent1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineAuthoring.SplineNode>.NativeClassPtr, nameof (Tangent1));
        SplineAuthoring.SplineNode.NativeFieldInfoPtr_Tangent2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineAuthoring.SplineNode>.NativeClassPtr, nameof (Tangent2));
        SplineAuthoring.SplineNode.NativeFieldInfoPtr_IsLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineAuthoring.SplineNode>.NativeClassPtr, nameof (IsLocked));
        SplineAuthoring.SplineNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplineAuthoring.SplineNode>.NativeClassPtr, 100666050);
      }

      public SplineNode(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Vector3 Position
      {
        get
        {
          return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.SplineNode.NativeFieldInfoPtr_Position));
        }
        [param: In] set
        {
          *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.SplineNode.NativeFieldInfoPtr_Position)) = value;
        }
      }

      public unsafe Vector3 Tangent1
      {
        get
        {
          return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.SplineNode.NativeFieldInfoPtr_Tangent1));
        }
        [param: In] set
        {
          *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.SplineNode.NativeFieldInfoPtr_Tangent1)) = value;
        }
      }

      public unsafe Vector3 Tangent2
      {
        get
        {
          return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.SplineNode.NativeFieldInfoPtr_Tangent2));
        }
        [param: In] set
        {
          *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.SplineNode.NativeFieldInfoPtr_Tangent2)) = value;
        }
      }

      public unsafe bool IsLocked
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.SplineNode.NativeFieldInfoPtr_IsLocked));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.SplineNode.NativeFieldInfoPtr_IsLocked)) = value;
        }
      }
    }

    public enum SplineEditNodeType
    {
      Position,
      Tangent1,
      Tangent2,
    }

    public enum FreeDragPickMode
    {
      GameplayHeight,
      Everything,
    }

    public enum MeshGenMode
    {
      CreateNew,
      ChooseExisting,
    }

    [Serializable]
    public class SubSpline : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_SplineNodes;
      private static readonly System.IntPtr NativeFieldInfoPtr_SplineColor;
      private static readonly System.IntPtr NativeFieldInfoPtr_SegmentsPerMOverride;
      private static readonly System.IntPtr NativeFieldInfoPtr_Width;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750324, XrefRangeEnd = 750332, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe SubSpline()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SplineAuthoring.SubSpline>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SplineAuthoring.SubSpline.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static SubSpline()
      {
        Il2CppClassPointerStore<SplineAuthoring.SubSpline>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SplineAuthoring>.NativeClassPtr, nameof (SubSpline));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SplineAuthoring.SubSpline>.NativeClassPtr);
        SplineAuthoring.SubSpline.NativeFieldInfoPtr_SplineNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineAuthoring.SubSpline>.NativeClassPtr, nameof (SplineNodes));
        SplineAuthoring.SubSpline.NativeFieldInfoPtr_SplineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineAuthoring.SubSpline>.NativeClassPtr, nameof (SplineColor));
        SplineAuthoring.SubSpline.NativeFieldInfoPtr_SegmentsPerMOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineAuthoring.SubSpline>.NativeClassPtr, nameof (SegmentsPerMOverride));
        SplineAuthoring.SubSpline.NativeFieldInfoPtr_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplineAuthoring.SubSpline>.NativeClassPtr, nameof (Width));
        SplineAuthoring.SubSpline.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SplineAuthoring.SubSpline>.NativeClassPtr, 100666051);
      }

      public SubSpline(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe List<SplineAuthoring.SplineNode> SplineNodes
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.SubSpline.NativeFieldInfoPtr_SplineNodes));
          return pointer == System.IntPtr.Zero ? (List<SplineAuthoring.SplineNode>) null : new List<SplineAuthoring.SplineNode>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.SubSpline.NativeFieldInfoPtr_SplineNodes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Color SplineColor
      {
        get
        {
          return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.SubSpline.NativeFieldInfoPtr_SplineColor));
        }
        [param: In] set
        {
          *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.SubSpline.NativeFieldInfoPtr_SplineColor)) = value;
        }
      }

      public unsafe float SegmentsPerMOverride
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.SubSpline.NativeFieldInfoPtr_SegmentsPerMOverride));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.SubSpline.NativeFieldInfoPtr_SegmentsPerMOverride)) = value;
        }
      }

      public unsafe float Width
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.SubSpline.NativeFieldInfoPtr_Width));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SplineAuthoring.SubSpline.NativeFieldInfoPtr_Width)) = value;
        }
      }
    }
  }
}
