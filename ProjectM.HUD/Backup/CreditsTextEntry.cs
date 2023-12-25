// Decompiled with JetBrains decompiler
// Type: CreditsTextEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

#nullable disable
public class CreditsTextEntry : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_PreSpacingRect;
  private static readonly IntPtr NativeFieldInfoPtr_PostSpacingRect;
  private static readonly IntPtr NativeFieldInfoPtr_Text;
  private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_String_Single_Single_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208327, XrefRangeEnd = 1208331, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetData(string text, float preSpacing, float postSpacing, float fontSize)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &preSpacing;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &postSpacing;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &fontSize;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CreditsTextEntry.NativeMethodInfoPtr_SetData_Public_Void_String_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(520)]
  [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CreditsTextEntry()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreditsTextEntry>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CreditsTextEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CreditsTextEntry()
  {
    Il2CppClassPointerStore<CreditsTextEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (CreditsTextEntry));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreditsTextEntry>.NativeClassPtr);
    CreditsTextEntry.NativeFieldInfoPtr_PreSpacingRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreditsTextEntry>.NativeClassPtr, nameof (PreSpacingRect));
    CreditsTextEntry.NativeFieldInfoPtr_PostSpacingRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreditsTextEntry>.NativeClassPtr, nameof (PostSpacingRect));
    CreditsTextEntry.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreditsTextEntry>.NativeClassPtr, nameof (Text));
    CreditsTextEntry.NativeMethodInfoPtr_SetData_Public_Void_String_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreditsTextEntry>.NativeClassPtr, 100663512);
    CreditsTextEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreditsTextEntry>.NativeClassPtr, 100663513);
  }

  public CreditsTextEntry(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe RectTransform PreSpacingRect
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreditsTextEntry.NativeFieldInfoPtr_PreSpacingRect));
      return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CreditsTextEntry.NativeFieldInfoPtr_PreSpacingRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform PostSpacingRect
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreditsTextEntry.NativeFieldInfoPtr_PostSpacingRect));
      return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CreditsTextEntry.NativeFieldInfoPtr_PostSpacingRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TextMeshProUGUI Text
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreditsTextEntry.NativeFieldInfoPtr_Text));
      return pointer == IntPtr.Zero ? (TextMeshProUGUI) null : new TextMeshProUGUI(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CreditsTextEntry.NativeFieldInfoPtr_Text), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
