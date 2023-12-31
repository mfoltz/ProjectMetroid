// Decompiled with JetBrains decompiler
// Type: ProjectM.ServantSkinColor
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public class ServantSkinColor : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SkinColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_PossibleHairColors;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServantSkinColor()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServantSkinColor>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantSkinColor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ServantSkinColor()
    {
      Il2CppClassPointerStore<ServantSkinColor>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ServantSkinColor));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantSkinColor>.NativeClassPtr);
      ServantSkinColor.NativeFieldInfoPtr_SkinColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSkinColor>.NativeClassPtr, nameof (SkinColor));
      ServantSkinColor.NativeFieldInfoPtr_PossibleHairColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantSkinColor>.NativeClassPtr, nameof (PossibleHairColors));
      ServantSkinColor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantSkinColor>.NativeClassPtr, 100665761);
    }

    public ServantSkinColor(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ServantColor SkinColor
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSkinColor.NativeFieldInfoPtr_SkinColor));
        return pointer == System.IntPtr.Zero ? (ServantColor) null : new ServantColor(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantSkinColor.NativeFieldInfoPtr_SkinColor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<ServantColor> PossibleHairColors
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantSkinColor.NativeFieldInfoPtr_PossibleHairColors));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ServantColor>) null : new Il2CppReferenceArray<ServantColor>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantSkinColor.NativeFieldInfoPtr_PossibleHairColors), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
