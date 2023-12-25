// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ScrollingCombatTextEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using TMPro;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.UI
{
  public class ScrollingCombatTextEntry : UIEntry
  {
    private static readonly IntPtr NativeFieldInfoPtr_Position;
    private static readonly IntPtr NativeFieldInfoPtr_Text;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ScrollingCombatTextEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollingCombatTextEntry>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScrollingCombatTextEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ScrollingCombatTextEntry()
    {
      Il2CppClassPointerStore<ScrollingCombatTextEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ScrollingCombatTextEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollingCombatTextEntry>.NativeClassPtr);
      ScrollingCombatTextEntry.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatTextEntry>.NativeClassPtr, nameof (Position));
      ScrollingCombatTextEntry.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatTextEntry>.NativeClassPtr, nameof (Text));
      ScrollingCombatTextEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollingCombatTextEntry>.NativeClassPtr, 100668430);
    }

    public ScrollingCombatTextEntry(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float2 Position
    {
      get
      {
        return *(float2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollingCombatTextEntry.NativeFieldInfoPtr_Position));
      }
      [param: In] set
      {
        *(float2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollingCombatTextEntry.NativeFieldInfoPtr_Position)) = value;
      }
    }

    public unsafe TextMeshProUGUI Text
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollingCombatTextEntry.NativeFieldInfoPtr_Text));
        return pointer == IntPtr.Zero ? (TextMeshProUGUI) null : new TextMeshProUGUI(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScrollingCombatTextEntry.NativeFieldInfoPtr_Text), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
