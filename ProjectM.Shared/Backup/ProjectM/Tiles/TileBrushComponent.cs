// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileBrushComponent
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
  public class TileBrushComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_LabelName;
    private static readonly IntPtr NativeFieldInfoPtr_Color;
    private static readonly IntPtr NativeFieldInfoPtr_DisplayName;
    private static readonly IntPtr NativeFieldInfoPtr_DisplayFromFolderRoot;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileBrushComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileBrushComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileBrushComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TileBrushComponent()
    {
      Il2CppClassPointerStore<TileBrushComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (TileBrushComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileBrushComponent>.NativeClassPtr);
      TileBrushComponent.NativeFieldInfoPtr_LabelName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBrushComponent>.NativeClassPtr, nameof (LabelName));
      TileBrushComponent.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBrushComponent>.NativeClassPtr, nameof (Color));
      TileBrushComponent.NativeFieldInfoPtr_DisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBrushComponent>.NativeClassPtr, nameof (DisplayName));
      TileBrushComponent.NativeFieldInfoPtr_DisplayFromFolderRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBrushComponent>.NativeClassPtr, nameof (DisplayFromFolderRoot));
      TileBrushComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBrushComponent>.NativeClassPtr, 100669881);
    }

    public TileBrushComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string LabelName
    {
      get
      {
        IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(TileBrushComponent.NativeFieldInfoPtr_LabelName, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TileBrushComponent.NativeFieldInfoPtr_LabelName, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe Color Color
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileBrushComponent.NativeFieldInfoPtr_Color));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileBrushComponent.NativeFieldInfoPtr_Color)) = value;
      }
    }

    public unsafe string DisplayName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileBrushComponent.NativeFieldInfoPtr_DisplayName)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TileBrushComponent.NativeFieldInfoPtr_DisplayName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string DisplayFromFolderRoot
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileBrushComponent.NativeFieldInfoPtr_DisplayFromFolderRoot)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TileBrushComponent.NativeFieldInfoPtr_DisplayFromFolderRoot), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
