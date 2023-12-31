// Decompiled with JetBrains decompiler
// Type: StunShared.UI.UIEntry
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace StunShared.UI
{
  public class UIEntry : StunGUIBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_EntryIndex;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UIEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIEntry>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIEntry.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UIEntry()
    {
      Il2CppClassPointerStore<UIEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "StunShared.UI", nameof (UIEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIEntry>.NativeClassPtr);
      UIEntry.NativeFieldInfoPtr_EntryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIEntry>.NativeClassPtr, nameof (EntryIndex));
      UIEntry.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIEntry>.NativeClassPtr, 100663544);
    }

    public UIEntry(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int EntryIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIEntry.NativeFieldInfoPtr_EntryIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIEntry.NativeFieldInfoPtr_EntryIndex)) = value;
      }
    }
  }
}
