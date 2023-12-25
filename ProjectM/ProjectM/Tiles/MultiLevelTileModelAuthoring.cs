// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.MultiLevelTileModelAuthoring
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
namespace ProjectM.Tiles
{
  public class MultiLevelTileModelAuthoring : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_BoundsMode;
    private static readonly IntPtr NativeFieldInfoPtr_Min;
    private static readonly IntPtr NativeFieldInfoPtr_Max;
    private static readonly IntPtr NativeFieldInfoPtr_SupportMultiLevelAttachesAndRequires;
    private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetBounds_Public_Void_byref_Single_byref_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetBoundsFromRenderers_Public_Static_Void_Transform_byref_Single_byref_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085573, XrefRangeEnd = 1085586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDrawGizmosSelected()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MultiLevelTileModelAuthoring.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1085586, RefRangeEnd = 1085587, XrefRangeStart = 1085586, XrefRangeEnd = 1085586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetBounds(out float minY, out float maxY)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) ref minY;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref maxY;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MultiLevelTileModelAuthoring.NativeMethodInfoPtr_GetBounds_Public_Void_byref_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1085590, RefRangeEnd = 1085593, XrefRangeStart = 1085587, XrefRangeEnd = 1085590, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetBoundsFromRenderers(
      Transform rootTransform,
      out float minY,
      out float maxY)
    {
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rootTransform);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref minY;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref maxY;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MultiLevelTileModelAuthoring.NativeMethodInfoPtr_GetBoundsFromRenderers_Public_Static_Void_Transform_byref_Single_byref_Single_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MultiLevelTileModelAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiLevelTileModelAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MultiLevelTileModelAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MultiLevelTileModelAuthoring()
    {
      Il2CppClassPointerStore<MultiLevelTileModelAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Tiles", nameof (MultiLevelTileModelAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiLevelTileModelAuthoring>.NativeClassPtr);
      MultiLevelTileModelAuthoring.NativeFieldInfoPtr_BoundsMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiLevelTileModelAuthoring>.NativeClassPtr, nameof (BoundsMode));
      MultiLevelTileModelAuthoring.NativeFieldInfoPtr_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiLevelTileModelAuthoring>.NativeClassPtr, nameof (Min));
      MultiLevelTileModelAuthoring.NativeFieldInfoPtr_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiLevelTileModelAuthoring>.NativeClassPtr, nameof (Max));
      MultiLevelTileModelAuthoring.NativeFieldInfoPtr_SupportMultiLevelAttachesAndRequires = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiLevelTileModelAuthoring>.NativeClassPtr, nameof (SupportMultiLevelAttachesAndRequires));
      MultiLevelTileModelAuthoring.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiLevelTileModelAuthoring>.NativeClassPtr, 100685505);
      MultiLevelTileModelAuthoring.NativeMethodInfoPtr_GetBounds_Public_Void_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiLevelTileModelAuthoring>.NativeClassPtr, 100685506);
      MultiLevelTileModelAuthoring.NativeMethodInfoPtr_GetBoundsFromRenderers_Public_Static_Void_Transform_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiLevelTileModelAuthoring>.NativeClassPtr, 100685507);
      MultiLevelTileModelAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiLevelTileModelAuthoring>.NativeClassPtr, 100685508);
    }

    public MultiLevelTileModelAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TileModelHeightBoundsMode BoundsMode
    {
      get
      {
        return *(TileModelHeightBoundsMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MultiLevelTileModelAuthoring.NativeFieldInfoPtr_BoundsMode));
      }
      [param: In] set
      {
        *(TileModelHeightBoundsMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MultiLevelTileModelAuthoring.NativeFieldInfoPtr_BoundsMode)) = value;
      }
    }

    public unsafe float Min
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MultiLevelTileModelAuthoring.NativeFieldInfoPtr_Min));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MultiLevelTileModelAuthoring.NativeFieldInfoPtr_Min)) = value;
      }
    }

    public unsafe float Max
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MultiLevelTileModelAuthoring.NativeFieldInfoPtr_Max));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MultiLevelTileModelAuthoring.NativeFieldInfoPtr_Max)) = value;
      }
    }

    public unsafe bool SupportMultiLevelAttachesAndRequires
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MultiLevelTileModelAuthoring.NativeFieldInfoPtr_SupportMultiLevelAttachesAndRequires));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MultiLevelTileModelAuthoring.NativeFieldInfoPtr_SupportMultiLevelAttachesAndRequires)) = value;
      }
    }
  }
}
