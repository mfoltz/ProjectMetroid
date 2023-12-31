// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.RoadTypeAsset
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Terrain
{
  public class RoadTypeAsset : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_RoadType;
    private static readonly IntPtr NativeFieldInfoPtr_RoadPriority;
    private static readonly IntPtr NativeFieldInfoPtr_RoadWidth;
    private static readonly IntPtr NativeFieldInfoPtr_EditorColor;
    private static readonly IntPtr NativeFieldInfoPtr_MinimapRoadWidth;
    private static readonly IntPtr NativeMethodInfoPtr_GetEdgeVisualizationData_Public_Static_Void_RoadTypeAsset_RoadTypeAsset_byref_Color_byref_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetEdgeType_Public_Static_RoadType_RoadType_RoadType_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768645, XrefRangeEnd = 768667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetEdgeVisualizationData(
      RoadTypeAsset roadType1,
      RoadTypeAsset roadType2,
      out Color edgeColor,
      out float width)
    {
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) roadType1);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) roadType2);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref edgeColor;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) ref width;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RoadTypeAsset.NativeMethodInfoPtr_GetEdgeVisualizationData_Public_Static_Void_RoadTypeAsset_RoadTypeAsset_byref_Color_byref_Single_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 768673, RefRangeEnd = 768674, XrefRangeStart = 768667, XrefRangeEnd = 768673, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe RoadType GetEdgeType(RoadType type1, RoadType type2)
    {
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &type1;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &type2;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoadTypeAsset.NativeMethodInfoPtr_GetEdgeType_Public_Static_RoadType_RoadType_RoadType_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(RoadType*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RoadTypeAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoadTypeAsset>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RoadTypeAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RoadTypeAsset()
    {
      Il2CppClassPointerStore<RoadTypeAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (RoadTypeAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoadTypeAsset>.NativeClassPtr);
      RoadTypeAsset.NativeFieldInfoPtr_RoadType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadTypeAsset>.NativeClassPtr, nameof (RoadType));
      RoadTypeAsset.NativeFieldInfoPtr_RoadPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadTypeAsset>.NativeClassPtr, nameof (RoadPriority));
      RoadTypeAsset.NativeFieldInfoPtr_RoadWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadTypeAsset>.NativeClassPtr, nameof (RoadWidth));
      RoadTypeAsset.NativeFieldInfoPtr_EditorColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadTypeAsset>.NativeClassPtr, nameof (EditorColor));
      RoadTypeAsset.NativeFieldInfoPtr_MinimapRoadWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadTypeAsset>.NativeClassPtr, nameof (MinimapRoadWidth));
      RoadTypeAsset.NativeMethodInfoPtr_GetEdgeVisualizationData_Public_Static_Void_RoadTypeAsset_RoadTypeAsset_byref_Color_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadTypeAsset>.NativeClassPtr, 100668002);
      RoadTypeAsset.NativeMethodInfoPtr_GetEdgeType_Public_Static_RoadType_RoadType_RoadType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadTypeAsset>.NativeClassPtr, 100668003);
      RoadTypeAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadTypeAsset>.NativeClassPtr, 100668004);
    }

    public RoadTypeAsset(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe RoadType RoadType
    {
      get
      {
        return *(RoadType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoadTypeAsset.NativeFieldInfoPtr_RoadType));
      }
      [param: In] set
      {
        *(RoadType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoadTypeAsset.NativeFieldInfoPtr_RoadType)) = value;
      }
    }

    public unsafe int RoadPriority
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoadTypeAsset.NativeFieldInfoPtr_RoadPriority));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoadTypeAsset.NativeFieldInfoPtr_RoadPriority)) = value;
      }
    }

    public unsafe float RoadWidth
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoadTypeAsset.NativeFieldInfoPtr_RoadWidth));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoadTypeAsset.NativeFieldInfoPtr_RoadWidth)) = value;
      }
    }

    public unsafe Color EditorColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoadTypeAsset.NativeFieldInfoPtr_EditorColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoadTypeAsset.NativeFieldInfoPtr_EditorColor)) = value;
      }
    }

    public unsafe float MinimapRoadWidth
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoadTypeAsset.NativeFieldInfoPtr_MinimapRoadWidth));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoadTypeAsset.NativeFieldInfoPtr_MinimapRoadWidth)) = value;
      }
    }
  }
}
