// Decompiled with JetBrains decompiler
// Type: MountSaddleEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class MountSaddleEntry : GridSelectionEntry
{
  private static readonly IntPtr NativeFieldInfoPtr_IconImage;
  private static readonly IntPtr NativeFieldInfoPtr_SaddleId;
  private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Void_Sprite_PrefabGUID_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205512, XrefRangeEnd = 1205513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Refresh(Sprite icon, PrefabGUID saddleId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) icon);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &saddleId;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MountSaddleEntry.NativeMethodInfoPtr_Refresh_Public_Void_Sprite_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MountSaddleEntry()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MountSaddleEntry>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MountSaddleEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static MountSaddleEntry()
  {
    Il2CppClassPointerStore<MountSaddleEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (MountSaddleEntry));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MountSaddleEntry>.NativeClassPtr);
    MountSaddleEntry.NativeFieldInfoPtr_IconImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSaddleEntry>.NativeClassPtr, nameof (IconImage));
    MountSaddleEntry.NativeFieldInfoPtr_SaddleId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSaddleEntry>.NativeClassPtr, nameof (SaddleId));
    MountSaddleEntry.NativeMethodInfoPtr_Refresh_Public_Void_Sprite_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MountSaddleEntry>.NativeClassPtr, 100663327);
    MountSaddleEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MountSaddleEntry>.NativeClassPtr, 100663328);
  }

  public MountSaddleEntry(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Image IconImage
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSaddleEntry.NativeFieldInfoPtr_IconImage));
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountSaddleEntry.NativeFieldInfoPtr_IconImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PrefabGUID SaddleId
  {
    get
    {
      return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSaddleEntry.NativeFieldInfoPtr_SaddleId));
    }
    [param: In] set
    {
      *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSaddleEntry.NativeFieldInfoPtr_SaddleId)) = value;
    }
  }
}
