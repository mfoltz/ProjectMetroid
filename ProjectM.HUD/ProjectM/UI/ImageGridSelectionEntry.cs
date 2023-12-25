// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ImageGridSelectionEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class ImageGridSelectionEntry : GridSelectionEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Image;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshData_Internal_Static_Void_ImageGridSelectionEntry_Data_ControllerType_GridSelectionGroup_2_ImageGridSelectionEntry_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1278704, RefRangeEnd = 1278705, XrefRangeStart = 1278700, XrefRangeEnd = 1278704, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RefreshData(
      ImageGridSelectionEntry entry,
      ImageGridSelectionEntry.Data data,
      ControllerType controllerType,
      GridSelectionGroup<ImageGridSelectionEntry, ImageGridSelectionEntry.Data> parent)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &controllerType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parent);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ImageGridSelectionEntry.NativeMethodInfoPtr_RefreshData_Internal_Static_Void_ImageGridSelectionEntry_Data_ControllerType_GridSelectionGroup_2_ImageGridSelectionEntry_Data_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ImageGridSelectionEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageGridSelectionEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ImageGridSelectionEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ImageGridSelectionEntry()
    {
      Il2CppClassPointerStore<ImageGridSelectionEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ImageGridSelectionEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageGridSelectionEntry>.NativeClassPtr);
      ImageGridSelectionEntry.NativeFieldInfoPtr_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageGridSelectionEntry>.NativeClassPtr, nameof (Image));
      ImageGridSelectionEntry.NativeMethodInfoPtr_RefreshData_Internal_Static_Void_ImageGridSelectionEntry_Data_ControllerType_GridSelectionGroup_2_ImageGridSelectionEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageGridSelectionEntry>.NativeClassPtr, 100668799);
      ImageGridSelectionEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageGridSelectionEntry>.NativeClassPtr, 100668800);
    }

    public ImageGridSelectionEntry(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Image Image
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImageGridSelectionEntry.NativeFieldInfoPtr_Image));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ImageGridSelectionEntry.NativeFieldInfoPtr_Image), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public sealed class Data : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_NormalSprite;
      private static readonly System.IntPtr NativeFieldInfoPtr_SelectedSprite;

      static Data()
      {
        Il2CppClassPointerStore<ImageGridSelectionEntry.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ImageGridSelectionEntry>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageGridSelectionEntry.Data>.NativeClassPtr);
        ImageGridSelectionEntry.Data.NativeFieldInfoPtr_NormalSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageGridSelectionEntry.Data>.NativeClassPtr, nameof (NormalSprite));
        ImageGridSelectionEntry.Data.NativeFieldInfoPtr_SelectedSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageGridSelectionEntry.Data>.NativeClassPtr, nameof (SelectedSprite));
      }

      public Data(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Data()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ImageGridSelectionEntry.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ImageGridSelectionEntry.Data>.NativeClassPtr, data));
      }

      public unsafe Sprite NormalSprite
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImageGridSelectionEntry.Data.NativeFieldInfoPtr_NormalSprite));
          return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ImageGridSelectionEntry.Data.NativeFieldInfoPtr_NormalSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Sprite SelectedSprite
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImageGridSelectionEntry.Data.NativeFieldInfoPtr_SelectedSprite));
          return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ImageGridSelectionEntry.Data.NativeFieldInfoPtr_SelectedSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
