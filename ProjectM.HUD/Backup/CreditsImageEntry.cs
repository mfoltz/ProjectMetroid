// Decompiled with JetBrains decompiler
// Type: CreditsImageEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class CreditsImageEntry : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_PreSpacingRect;
  private static readonly IntPtr NativeFieldInfoPtr_PostSpacingRect;
  private static readonly IntPtr NativeFieldInfoPtr_Image;
  private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_Sprite_Single_Single_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207685, XrefRangeEnd = 1207692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetData(Sprite sprite, float preSpacing, float postSpacing, float scale)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sprite);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &preSpacing;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &postSpacing;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &scale;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CreditsImageEntry.NativeMethodInfoPtr_SetData_Public_Void_Sprite_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(520)]
  [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CreditsImageEntry()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreditsImageEntry>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CreditsImageEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CreditsImageEntry()
  {
    Il2CppClassPointerStore<CreditsImageEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (CreditsImageEntry));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreditsImageEntry>.NativeClassPtr);
    CreditsImageEntry.NativeFieldInfoPtr_PreSpacingRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreditsImageEntry>.NativeClassPtr, nameof (PreSpacingRect));
    CreditsImageEntry.NativeFieldInfoPtr_PostSpacingRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreditsImageEntry>.NativeClassPtr, nameof (PostSpacingRect));
    CreditsImageEntry.NativeFieldInfoPtr_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreditsImageEntry>.NativeClassPtr, nameof (Image));
    CreditsImageEntry.NativeMethodInfoPtr_SetData_Public_Void_Sprite_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreditsImageEntry>.NativeClassPtr, 100663494);
    CreditsImageEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreditsImageEntry>.NativeClassPtr, 100663495);
  }

  public CreditsImageEntry(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe RectTransform PreSpacingRect
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreditsImageEntry.NativeFieldInfoPtr_PreSpacingRect));
      return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CreditsImageEntry.NativeFieldInfoPtr_PreSpacingRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform PostSpacingRect
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreditsImageEntry.NativeFieldInfoPtr_PostSpacingRect));
      return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CreditsImageEntry.NativeFieldInfoPtr_PostSpacingRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image Image
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreditsImageEntry.NativeFieldInfoPtr_Image));
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CreditsImageEntry.NativeFieldInfoPtr_Image), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
