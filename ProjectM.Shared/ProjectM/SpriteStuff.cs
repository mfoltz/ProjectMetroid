// Decompiled with JetBrains decompiler
// Type: ProjectM.SpriteStuff
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
namespace ProjectM
{
  [Serializable]
  public class SpriteStuff : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Normal;
    private static readonly System.IntPtr NativeFieldInfoPtr_Selected;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpriteStuff()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteStuff>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpriteStuff.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SpriteStuff()
    {
      Il2CppClassPointerStore<SpriteStuff>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SpriteStuff));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteStuff>.NativeClassPtr);
      SpriteStuff.NativeFieldInfoPtr_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteStuff>.NativeClassPtr, nameof (Normal));
      SpriteStuff.NativeFieldInfoPtr_Selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteStuff>.NativeClassPtr, nameof (Selected));
      SpriteStuff.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteStuff>.NativeClassPtr, 100665878);
    }

    public SpriteStuff(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Sprite Normal
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteStuff.NativeFieldInfoPtr_Normal));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpriteStuff.NativeFieldInfoPtr_Normal), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Selected
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteStuff.NativeFieldInfoPtr_Selected));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpriteStuff.NativeFieldInfoPtr_Selected), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
