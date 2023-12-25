// Decompiled with JetBrains decompiler
// Type: SpawnPointSelectionEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.UI;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class SpawnPointSelectionEntry : UIEntry
{
  private static readonly IntPtr NativeFieldInfoPtr_Button;
  private static readonly IntPtr NativeFieldInfoPtr_ButtonText;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(41)]
  [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SpawnPointSelectionEntry()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpawnPointSelectionEntry>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SpawnPointSelectionEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SpawnPointSelectionEntry()
  {
    Il2CppClassPointerStore<SpawnPointSelectionEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (SpawnPointSelectionEntry));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnPointSelectionEntry>.NativeClassPtr);
    SpawnPointSelectionEntry.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnPointSelectionEntry>.NativeClassPtr, nameof (Button));
    SpawnPointSelectionEntry.NativeFieldInfoPtr_ButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnPointSelectionEntry>.NativeClassPtr, nameof (ButtonText));
    SpawnPointSelectionEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnPointSelectionEntry>.NativeClassPtr, 100663411);
  }

  public SpawnPointSelectionEntry(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe SimpleStunButton Button
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnPointSelectionEntry.NativeFieldInfoPtr_Button));
      return pointer == IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpawnPointSelectionEntry.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedText ButtonText
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnPointSelectionEntry.NativeFieldInfoPtr_ButtonText));
      return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpawnPointSelectionEntry.NativeFieldInfoPtr_ButtonText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
