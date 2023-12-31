// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileBrushLineOfSightComponent
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
namespace ProjectM.Tiles
{
  public class TileBrushLineOfSightComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_LineOfSightTileFlags;
    private static readonly IntPtr NativeMethodInfoPtr_get_BrushType_Public_Virtual_Final_New_get_TileBrushType_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Virtual_Final_New_ITileData_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public virtual unsafe TileBrushType BrushType
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileBrushLineOfSightComponent.NativeMethodInfoPtr_get_BrushType_Public_Virtual_Final_New_get_TileBrushType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(TileBrushType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793432, XrefRangeEnd = 793435, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe ITileData GetData()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileBrushLineOfSightComponent.NativeMethodInfoPtr_GetData_Public_Virtual_Final_New_ITileData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (ITileData) null : new ITileData(pointer);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileBrushLineOfSightComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileBrushLineOfSightComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileBrushLineOfSightComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TileBrushLineOfSightComponent()
    {
      Il2CppClassPointerStore<TileBrushLineOfSightComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (TileBrushLineOfSightComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileBrushLineOfSightComponent>.NativeClassPtr);
      TileBrushLineOfSightComponent.NativeFieldInfoPtr_LineOfSightTileFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBrushLineOfSightComponent>.NativeClassPtr, nameof (LineOfSightTileFlags));
      TileBrushLineOfSightComponent.NativeMethodInfoPtr_get_BrushType_Public_Virtual_Final_New_get_TileBrushType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBrushLineOfSightComponent>.NativeClassPtr, 100669882);
      TileBrushLineOfSightComponent.NativeMethodInfoPtr_GetData_Public_Virtual_Final_New_ITileData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBrushLineOfSightComponent>.NativeClassPtr, 100669883);
      TileBrushLineOfSightComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBrushLineOfSightComponent>.NativeClassPtr, 100669884);
    }

    public TileBrushLineOfSightComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LineOfSightTileFlags LineOfSightTileFlags
    {
      get
      {
        return *(LineOfSightTileFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileBrushLineOfSightComponent.NativeFieldInfoPtr_LineOfSightTileFlags));
      }
      [param: In] set
      {
        *(LineOfSightTileFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileBrushLineOfSightComponent.NativeFieldInfoPtr_LineOfSightTileFlags)) = value;
      }
    }
  }
}
