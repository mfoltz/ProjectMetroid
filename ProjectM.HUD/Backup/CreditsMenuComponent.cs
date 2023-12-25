// Decompiled with JetBrains decompiler
// Type: CreditsMenuComponent
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class CreditsMenuComponent : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_EntriesParent;
  private static readonly System.IntPtr NativeFieldInfoPtr_Entries;
  private static readonly System.IntPtr NativeFieldInfoPtr_Speed;
  private static readonly System.IntPtr NativeFieldInfoPtr_StunlockLogo;
  private static readonly System.IntPtr NativeFieldInfoPtr_VRisingLogo;
  private static readonly System.IntPtr NativeFieldInfoPtr_UnityLogo;
  private static readonly System.IntPtr NativeFieldInfoPtr_FMODLogo;
  private static readonly System.IntPtr NativeFieldInfoPtr_VivoxLogo;
  private static readonly System.IntPtr NativeFieldInfoPtr_HuwizLogo;
  private static readonly System.IntPtr NativeFieldInfoPtr_TestronicLogo;
  private static readonly System.IntPtr NativeFieldInfoPtr_SpacingPrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_ImagePrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_TextPrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_StunlockList;
  private static readonly System.IntPtr NativeFieldInfoPtr_StunlockAdditionalList;
  private static readonly System.IntPtr NativeFieldInfoPtr_VoiceActors;
  private static readonly System.IntPtr NativeFieldInfoPtr__UpcomingEntries;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddLogo_Private_Void_Sprite_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddStandardName_Private_Void_String_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddCategory_Private_Void_String_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddSubCategory_Private_Void_String_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddSpacing_Private_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InstantiateNextEntry_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207695, XrefRangeEnd = 1208113, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CreditsMenuComponent.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 1208122, RefRangeEnd = 1208129, XrefRangeStart = 1208113, XrefRangeEnd = 1208122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddLogo(Sprite Image, float preSpacing = 0.0f, float postSpacing = 100f, float scale = 1f)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) Image);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &preSpacing;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &postSpacing;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &scale;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CreditsMenuComponent.NativeMethodInfoPtr_AddLogo_Private_Void_Sprite_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208129, XrefRangeEnd = 1208161, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CreditsMenuComponent.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(52)]
  [CachedScanResults(RefRangeStart = 1208170, RefRangeEnd = 1208222, XrefRangeStart = 1208161, XrefRangeEnd = 1208170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddStandardName(string personName, float fontSize = 36f)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(personName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fontSize;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CreditsMenuComponent.NativeMethodInfoPtr_AddStandardName_Private_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(15)]
  [CachedScanResults(RefRangeStart = 1208231, RefRangeEnd = 1208246, XrefRangeStart = 1208222, XrefRangeEnd = 1208231, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddCategory(string personName, float fontSize = 42f)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(personName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fontSize;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CreditsMenuComponent.NativeMethodInfoPtr_AddCategory_Private_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(13)]
  [CachedScanResults(RefRangeStart = 1208255, RefRangeEnd = 1208268, XrefRangeStart = 1208246, XrefRangeEnd = 1208255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddSubCategory(string personName, float fontSize = 24f)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(personName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fontSize;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CreditsMenuComponent.NativeMethodInfoPtr_AddSubCategory_Private_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208268, XrefRangeEnd = 1208276, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddSpacing(float spacing)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &spacing;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CreditsMenuComponent.NativeMethodInfoPtr_AddSpacing_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 1208316, RefRangeEnd = 1208317, XrefRangeStart = 1208276, XrefRangeEnd = 1208316, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InstantiateNextEntry()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CreditsMenuComponent.NativeMethodInfoPtr_InstantiateNextEntry_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208317, XrefRangeEnd = 1208325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CreditsMenuComponent()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreditsMenuComponent>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CreditsMenuComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CreditsMenuComponent()
  {
    Il2CppClassPointerStore<CreditsMenuComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (CreditsMenuComponent));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreditsMenuComponent>.NativeClassPtr);
    CreditsMenuComponent.NativeFieldInfoPtr_EntriesParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreditsMenuComponent>.NativeClassPtr, nameof (EntriesParent));
    CreditsMenuComponent.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreditsMenuComponent>.NativeClassPtr, nameof (Entries));
    CreditsMenuComponent.NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreditsMenuComponent>.NativeClassPtr, nameof (Speed));
    CreditsMenuComponent.NativeFieldInfoPtr_StunlockLogo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreditsMenuComponent>.NativeClassPtr, nameof (StunlockLogo));
    CreditsMenuComponent.NativeFieldInfoPtr_VRisingLogo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreditsMenuComponent>.NativeClassPtr, nameof (VRisingLogo));
    CreditsMenuComponent.NativeFieldInfoPtr_UnityLogo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreditsMenuComponent>.NativeClassPtr, nameof (UnityLogo));
    CreditsMenuComponent.NativeFieldInfoPtr_FMODLogo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreditsMenuComponent>.NativeClassPtr, nameof (FMODLogo));
    CreditsMenuComponent.NativeFieldInfoPtr_VivoxLogo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreditsMenuComponent>.NativeClassPtr, nameof (VivoxLogo));
    CreditsMenuComponent.NativeFieldInfoPtr_HuwizLogo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreditsMenuComponent>.NativeClassPtr, nameof (HuwizLogo));
    CreditsMenuComponent.NativeFieldInfoPtr_TestronicLogo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreditsMenuComponent>.NativeClassPtr, nameof (TestronicLogo));
    CreditsMenuComponent.NativeFieldInfoPtr_SpacingPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreditsMenuComponent>.NativeClassPtr, nameof (SpacingPrefab));
    CreditsMenuComponent.NativeFieldInfoPtr_ImagePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreditsMenuComponent>.NativeClassPtr, nameof (ImagePrefab));
    CreditsMenuComponent.NativeFieldInfoPtr_TextPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreditsMenuComponent>.NativeClassPtr, nameof (TextPrefab));
    CreditsMenuComponent.NativeFieldInfoPtr_StunlockList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreditsMenuComponent>.NativeClassPtr, nameof (StunlockList));
    CreditsMenuComponent.NativeFieldInfoPtr_StunlockAdditionalList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreditsMenuComponent>.NativeClassPtr, nameof (StunlockAdditionalList));
    CreditsMenuComponent.NativeFieldInfoPtr_VoiceActors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreditsMenuComponent>.NativeClassPtr, nameof (VoiceActors));
    CreditsMenuComponent.NativeFieldInfoPtr__UpcomingEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreditsMenuComponent>.NativeClassPtr, nameof (_UpcomingEntries));
    CreditsMenuComponent.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreditsMenuComponent>.NativeClassPtr, 100663497);
    CreditsMenuComponent.NativeMethodInfoPtr_AddLogo_Private_Void_Sprite_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreditsMenuComponent>.NativeClassPtr, 100663498);
    CreditsMenuComponent.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreditsMenuComponent>.NativeClassPtr, 100663499);
    CreditsMenuComponent.NativeMethodInfoPtr_AddStandardName_Private_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreditsMenuComponent>.NativeClassPtr, 100663500);
    CreditsMenuComponent.NativeMethodInfoPtr_AddCategory_Private_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreditsMenuComponent>.NativeClassPtr, 100663501);
    CreditsMenuComponent.NativeMethodInfoPtr_AddSubCategory_Private_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreditsMenuComponent>.NativeClassPtr, 100663502);
    CreditsMenuComponent.NativeMethodInfoPtr_AddSpacing_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreditsMenuComponent>.NativeClassPtr, 100663503);
    CreditsMenuComponent.NativeMethodInfoPtr_InstantiateNextEntry_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreditsMenuComponent>.NativeClassPtr, 100663504);
    CreditsMenuComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreditsMenuComponent>.NativeClassPtr, 100663505);
  }

  public CreditsMenuComponent(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe RectTransform EntriesParent
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.NativeFieldInfoPtr_EntriesParent));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.NativeFieldInfoPtr_EntriesParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<RectTransform> Entries
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.NativeFieldInfoPtr_Entries));
      return pointer == System.IntPtr.Zero ? (List<RectTransform>) null : new List<RectTransform>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float Speed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.NativeFieldInfoPtr_Speed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.NativeFieldInfoPtr_Speed)) = value;
    }
  }

  public unsafe Sprite StunlockLogo
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.NativeFieldInfoPtr_StunlockLogo));
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.NativeFieldInfoPtr_StunlockLogo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite VRisingLogo
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.NativeFieldInfoPtr_VRisingLogo));
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.NativeFieldInfoPtr_VRisingLogo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite UnityLogo
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.NativeFieldInfoPtr_UnityLogo));
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.NativeFieldInfoPtr_UnityLogo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite FMODLogo
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.NativeFieldInfoPtr_FMODLogo));
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.NativeFieldInfoPtr_FMODLogo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite VivoxLogo
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.NativeFieldInfoPtr_VivoxLogo));
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.NativeFieldInfoPtr_VivoxLogo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite HuwizLogo
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.NativeFieldInfoPtr_HuwizLogo));
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.NativeFieldInfoPtr_HuwizLogo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite TestronicLogo
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.NativeFieldInfoPtr_TestronicLogo));
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.NativeFieldInfoPtr_TestronicLogo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CreditsSpacingEntry SpacingPrefab
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.NativeFieldInfoPtr_SpacingPrefab));
      return pointer == System.IntPtr.Zero ? (CreditsSpacingEntry) null : new CreditsSpacingEntry(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.NativeFieldInfoPtr_SpacingPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CreditsImageEntry ImagePrefab
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.NativeFieldInfoPtr_ImagePrefab));
      return pointer == System.IntPtr.Zero ? (CreditsImageEntry) null : new CreditsImageEntry(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.NativeFieldInfoPtr_ImagePrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CreditsTextEntry TextPrefab
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.NativeFieldInfoPtr_TextPrefab));
      return pointer == System.IntPtr.Zero ? (CreditsTextEntry) null : new CreditsTextEntry(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.NativeFieldInfoPtr_TextPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TextAsset StunlockList
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.NativeFieldInfoPtr_StunlockList));
      return pointer == System.IntPtr.Zero ? (TextAsset) null : new TextAsset(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.NativeFieldInfoPtr_StunlockList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TextAsset StunlockAdditionalList
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.NativeFieldInfoPtr_StunlockAdditionalList));
      return pointer == System.IntPtr.Zero ? (TextAsset) null : new TextAsset(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.NativeFieldInfoPtr_StunlockAdditionalList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<VOCredits> VoiceActors
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.NativeFieldInfoPtr_VoiceActors));
      return pointer == System.IntPtr.Zero ? (List<VOCredits>) null : new List<VOCredits>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.NativeFieldInfoPtr_VoiceActors), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<CreditsMenuComponent.CreditsEntry> _UpcomingEntries
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.NativeFieldInfoPtr__UpcomingEntries));
      return pointer == System.IntPtr.Zero ? (List<CreditsMenuComponent.CreditsEntry>) null : new List<CreditsMenuComponent.CreditsEntry>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.NativeFieldInfoPtr__UpcomingEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public class CreditsEntry : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CreditsEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreditsMenuComponent.CreditsEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CreditsMenuComponent.CreditsEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CreditsEntry()
    {
      Il2CppClassPointerStore<CreditsMenuComponent.CreditsEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreditsMenuComponent>.NativeClassPtr, nameof (CreditsEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreditsMenuComponent.CreditsEntry>.NativeClassPtr);
      CreditsMenuComponent.CreditsEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreditsMenuComponent.CreditsEntry>.NativeClassPtr, 100663506);
    }

    public CreditsEntry(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }

  public class TextCreditsEntry : CreditsMenuComponent.CreditsEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PreSpacing;
    private static readonly System.IntPtr NativeFieldInfoPtr_Text;
    private static readonly System.IntPtr NativeFieldInfoPtr_PostSpacing;
    private static readonly System.IntPtr NativeFieldInfoPtr_FontSize;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TextCreditsEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreditsMenuComponent.TextCreditsEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CreditsMenuComponent.TextCreditsEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TextCreditsEntry()
    {
      Il2CppClassPointerStore<CreditsMenuComponent.TextCreditsEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreditsMenuComponent>.NativeClassPtr, nameof (TextCreditsEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreditsMenuComponent.TextCreditsEntry>.NativeClassPtr);
      CreditsMenuComponent.TextCreditsEntry.NativeFieldInfoPtr_PreSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreditsMenuComponent.TextCreditsEntry>.NativeClassPtr, nameof (PreSpacing));
      CreditsMenuComponent.TextCreditsEntry.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreditsMenuComponent.TextCreditsEntry>.NativeClassPtr, nameof (Text));
      CreditsMenuComponent.TextCreditsEntry.NativeFieldInfoPtr_PostSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreditsMenuComponent.TextCreditsEntry>.NativeClassPtr, nameof (PostSpacing));
      CreditsMenuComponent.TextCreditsEntry.NativeFieldInfoPtr_FontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreditsMenuComponent.TextCreditsEntry>.NativeClassPtr, nameof (FontSize));
      CreditsMenuComponent.TextCreditsEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreditsMenuComponent.TextCreditsEntry>.NativeClassPtr, 100663507);
    }

    public TextCreditsEntry(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float PreSpacing
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.TextCreditsEntry.NativeFieldInfoPtr_PreSpacing));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.TextCreditsEntry.NativeFieldInfoPtr_PreSpacing)) = value;
      }
    }

    public unsafe string Text
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.TextCreditsEntry.NativeFieldInfoPtr_Text)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.TextCreditsEntry.NativeFieldInfoPtr_Text), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe float PostSpacing
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.TextCreditsEntry.NativeFieldInfoPtr_PostSpacing));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.TextCreditsEntry.NativeFieldInfoPtr_PostSpacing)) = value;
      }
    }

    public unsafe float FontSize
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.TextCreditsEntry.NativeFieldInfoPtr_FontSize));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.TextCreditsEntry.NativeFieldInfoPtr_FontSize)) = value;
      }
    }
  }

  public class SpacingEntry : CreditsMenuComponent.CreditsEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Height;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpacingEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreditsMenuComponent.SpacingEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CreditsMenuComponent.SpacingEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SpacingEntry()
    {
      Il2CppClassPointerStore<CreditsMenuComponent.SpacingEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreditsMenuComponent>.NativeClassPtr, nameof (SpacingEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreditsMenuComponent.SpacingEntry>.NativeClassPtr);
      CreditsMenuComponent.SpacingEntry.NativeFieldInfoPtr_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreditsMenuComponent.SpacingEntry>.NativeClassPtr, nameof (Height));
      CreditsMenuComponent.SpacingEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreditsMenuComponent.SpacingEntry>.NativeClassPtr, 100663508);
    }

    public SpacingEntry(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float Height
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.SpacingEntry.NativeFieldInfoPtr_Height));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.SpacingEntry.NativeFieldInfoPtr_Height)) = value;
      }
    }
  }

  public class ImageCreditsEntry : CreditsMenuComponent.CreditsEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PreSpacing;
    private static readonly System.IntPtr NativeFieldInfoPtr_Image;
    private static readonly System.IntPtr NativeFieldInfoPtr_PostSpacing;
    private static readonly System.IntPtr NativeFieldInfoPtr_Scale;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ImageCreditsEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreditsMenuComponent.ImageCreditsEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CreditsMenuComponent.ImageCreditsEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ImageCreditsEntry()
    {
      Il2CppClassPointerStore<CreditsMenuComponent.ImageCreditsEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreditsMenuComponent>.NativeClassPtr, nameof (ImageCreditsEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreditsMenuComponent.ImageCreditsEntry>.NativeClassPtr);
      CreditsMenuComponent.ImageCreditsEntry.NativeFieldInfoPtr_PreSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreditsMenuComponent.ImageCreditsEntry>.NativeClassPtr, nameof (PreSpacing));
      CreditsMenuComponent.ImageCreditsEntry.NativeFieldInfoPtr_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreditsMenuComponent.ImageCreditsEntry>.NativeClassPtr, nameof (Image));
      CreditsMenuComponent.ImageCreditsEntry.NativeFieldInfoPtr_PostSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreditsMenuComponent.ImageCreditsEntry>.NativeClassPtr, nameof (PostSpacing));
      CreditsMenuComponent.ImageCreditsEntry.NativeFieldInfoPtr_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreditsMenuComponent.ImageCreditsEntry>.NativeClassPtr, nameof (Scale));
      CreditsMenuComponent.ImageCreditsEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreditsMenuComponent.ImageCreditsEntry>.NativeClassPtr, 100663509);
    }

    public ImageCreditsEntry(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float PreSpacing
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.ImageCreditsEntry.NativeFieldInfoPtr_PreSpacing));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.ImageCreditsEntry.NativeFieldInfoPtr_PreSpacing)) = value;
      }
    }

    public unsafe Sprite Image
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.ImageCreditsEntry.NativeFieldInfoPtr_Image));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.ImageCreditsEntry.NativeFieldInfoPtr_Image), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float PostSpacing
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.ImageCreditsEntry.NativeFieldInfoPtr_PostSpacing));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.ImageCreditsEntry.NativeFieldInfoPtr_PostSpacing)) = value;
      }
    }

    public unsafe float Scale
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.ImageCreditsEntry.NativeFieldInfoPtr_Scale));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreditsMenuComponent.ImageCreditsEntry.NativeFieldInfoPtr_Scale)) = value;
      }
    }
  }
}
