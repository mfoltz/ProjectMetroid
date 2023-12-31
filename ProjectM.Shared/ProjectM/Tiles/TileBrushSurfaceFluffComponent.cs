// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileBrushSurfaceFluffComponent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Terrain;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Tiles
{
  public class TileBrushSurfaceFluffComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_FluffAllowance;
    private static readonly IntPtr NativeMethodInfoPtr_get_BrushType_Public_Virtual_Final_New_get_TileBrushType_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Virtual_Final_New_ITileData_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public virtual unsafe TileBrushType BrushType
    {
      [CallerCount(21), CachedScanResults(RefRangeStart = 31081, RefRangeEnd = 31102, XrefRangeStart = 31081, XrefRangeEnd = 31102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileBrushSurfaceFluffComponent.NativeMethodInfoPtr_get_BrushType_Public_Virtual_Final_New_get_TileBrushType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(TileBrushType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793459, XrefRangeEnd = 793462, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe ITileData GetData()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileBrushSurfaceFluffComponent.NativeMethodInfoPtr_GetData_Public_Virtual_Final_New_ITileData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (ITileData) null : new ITileData(pointer);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileBrushSurfaceFluffComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileBrushSurfaceFluffComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileBrushSurfaceFluffComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TileBrushSurfaceFluffComponent()
    {
      Il2CppClassPointerStore<TileBrushSurfaceFluffComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (TileBrushSurfaceFluffComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileBrushSurfaceFluffComponent>.NativeClassPtr);
      TileBrushSurfaceFluffComponent.NativeFieldInfoPtr_FluffAllowance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBrushSurfaceFluffComponent>.NativeClassPtr, nameof (FluffAllowance));
      TileBrushSurfaceFluffComponent.NativeMethodInfoPtr_get_BrushType_Public_Virtual_Final_New_get_TileBrushType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBrushSurfaceFluffComponent>.NativeClassPtr, 100669894);
      TileBrushSurfaceFluffComponent.NativeMethodInfoPtr_GetData_Public_Virtual_Final_New_ITileData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBrushSurfaceFluffComponent>.NativeClassPtr, 100669895);
      TileBrushSurfaceFluffComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBrushSurfaceFluffComponent>.NativeClassPtr, 100669896);
    }

    public TileBrushSurfaceFluffComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe FluffAllowanceFlags FluffAllowance
    {
      get
      {
        return *(FluffAllowanceFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileBrushSurfaceFluffComponent.NativeFieldInfoPtr_FluffAllowance));
      }
      [param: In] set
      {
        *(FluffAllowanceFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileBrushSurfaceFluffComponent.NativeFieldInfoPtr_FluffAllowance)) = value;
      }
    }
  }
}
