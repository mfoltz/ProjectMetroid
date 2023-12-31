// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileBrushCollisionComponent
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
  public class TileBrushCollisionComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_CollisionFlags;
    private static readonly IntPtr NativeMethodInfoPtr_get_BrushType_Public_Virtual_Final_New_get_TileBrushType_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Virtual_Final_New_ITileData_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public virtual unsafe TileBrushType BrushType
    {
      [CallerCount(1474), CachedScanResults(RefRangeStart = 31223, RefRangeEnd = 32697, XrefRangeStart = 31223, XrefRangeEnd = 32697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileBrushCollisionComponent.NativeMethodInfoPtr_get_BrushType_Public_Virtual_Final_New_get_TileBrushType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(TileBrushType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793429, XrefRangeEnd = 793432, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe ITileData GetData()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileBrushCollisionComponent.NativeMethodInfoPtr_GetData_Public_Virtual_Final_New_ITileData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (ITileData) null : new ITileData(pointer);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileBrushCollisionComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileBrushCollisionComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileBrushCollisionComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TileBrushCollisionComponent()
    {
      Il2CppClassPointerStore<TileBrushCollisionComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (TileBrushCollisionComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileBrushCollisionComponent>.NativeClassPtr);
      TileBrushCollisionComponent.NativeFieldInfoPtr_CollisionFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBrushCollisionComponent>.NativeClassPtr, nameof (CollisionFlags));
      TileBrushCollisionComponent.NativeMethodInfoPtr_get_BrushType_Public_Virtual_Final_New_get_TileBrushType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBrushCollisionComponent>.NativeClassPtr, 100669875);
      TileBrushCollisionComponent.NativeMethodInfoPtr_GetData_Public_Virtual_Final_New_ITileData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBrushCollisionComponent>.NativeClassPtr, 100669876);
      TileBrushCollisionComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBrushCollisionComponent>.NativeClassPtr, 100669877);
    }

    public TileBrushCollisionComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe MapCollisionFlags CollisionFlags
    {
      get
      {
        return *(MapCollisionFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileBrushCollisionComponent.NativeFieldInfoPtr_CollisionFlags));
      }
      [param: In] set
      {
        *(MapCollisionFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileBrushCollisionComponent.NativeFieldInfoPtr_CollisionFlags)) = value;
      }
    }
  }
}
