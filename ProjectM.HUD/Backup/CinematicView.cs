// Decompiled with JetBrains decompiler
// Type: CinematicView
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.UI;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class CinematicView : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_VideoPlayer;
  private static readonly System.IntPtr NativeFieldInfoPtr_Cinematics;
  private static readonly System.IntPtr NativeFieldInfoPtr__VideoStarted;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_VideoPlayer_started_Private_Void_VideoPlayer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_VideoPlayer_errorReceived_Private_Void_VideoPlayer_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207622, XrefRangeEnd = 1207681, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CinematicView.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 639894, RefRangeEnd = 639895, XrefRangeStart = 639894, XrefRangeEnd = 639895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void VideoPlayer_started(UnityEngine.Video.VideoPlayer source)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CinematicView.NativeMethodInfoPtr_VideoPlayer_started_Private_Void_VideoPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(10560)]
  [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void VideoPlayer_errorReceived(UnityEngine.Video.VideoPlayer source, string message)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(message);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CinematicView.NativeMethodInfoPtr_VideoPlayer_errorReceived_Private_Void_VideoPlayer_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207681, XrefRangeEnd = 1207685, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CinematicView.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(520)]
  [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinematicView()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinematicView>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CinematicView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CinematicView()
  {
    Il2CppClassPointerStore<CinematicView>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (CinematicView));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinematicView>.NativeClassPtr);
    CinematicView.NativeFieldInfoPtr_VideoPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinematicView>.NativeClassPtr, nameof (VideoPlayer));
    CinematicView.NativeFieldInfoPtr_Cinematics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinematicView>.NativeClassPtr, nameof (Cinematics));
    CinematicView.NativeFieldInfoPtr__VideoStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinematicView>.NativeClassPtr, nameof (_VideoStarted));
    CinematicView.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinematicView>.NativeClassPtr, 100663489);
    CinematicView.NativeMethodInfoPtr_VideoPlayer_started_Private_Void_VideoPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinematicView>.NativeClassPtr, 100663490);
    CinematicView.NativeMethodInfoPtr_VideoPlayer_errorReceived_Private_Void_VideoPlayer_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinematicView>.NativeClassPtr, 100663491);
    CinematicView.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinematicView>.NativeClassPtr, 100663492);
    CinematicView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinematicView>.NativeClassPtr, 100663493);
  }

  public CinematicView(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe StunVideoPlayer VideoPlayer
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinematicView.NativeFieldInfoPtr_VideoPlayer));
      return pointer == System.IntPtr.Zero ? (StunVideoPlayer) null : new StunVideoPlayer(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinematicView.NativeFieldInfoPtr_VideoPlayer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<CinematicView.CinematicData> Cinematics
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinematicView.NativeFieldInfoPtr_Cinematics));
      return pointer == System.IntPtr.Zero ? (List<CinematicView.CinematicData>) null : new List<CinematicView.CinematicData>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinematicView.NativeFieldInfoPtr_Cinematics), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool _VideoStarted
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinematicView.NativeFieldInfoPtr__VideoStarted));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinematicView.NativeFieldInfoPtr__VideoStarted)) = value;
    }
  }

  [Serializable]
  public sealed class CinematicData : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Cinematic;
    private static readonly System.IntPtr NativeFieldInfoPtr_VideoAsset;

    static CinematicData()
    {
      Il2CppClassPointerStore<CinematicView.CinematicData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinematicView>.NativeClassPtr, nameof (CinematicData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinematicView.CinematicData>.NativeClassPtr);
      CinematicView.CinematicData.NativeFieldInfoPtr_Cinematic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinematicView.CinematicData>.NativeClassPtr, nameof (Cinematic));
      CinematicView.CinematicData.NativeFieldInfoPtr_VideoAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinematicView.CinematicData>.NativeClassPtr, nameof (VideoAsset));
    }

    public CinematicData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public CinematicData()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CinematicView.CinematicData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CinematicView.CinematicData>.NativeClassPtr, data));
    }

    public unsafe CinematicView.Cinematic Cinematic
    {
      get
      {
        return *(CinematicView.Cinematic*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinematicView.CinematicData.NativeFieldInfoPtr_Cinematic));
      }
      [param: In] set
      {
        *(CinematicView.Cinematic*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinematicView.CinematicData.NativeFieldInfoPtr_Cinematic)) = value;
      }
    }

    public unsafe StunVideoAsset VideoAsset
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinematicView.CinematicData.NativeFieldInfoPtr_VideoAsset));
        return pointer == System.IntPtr.Zero ? (StunVideoAsset) null : new StunVideoAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinematicView.CinematicData.NativeFieldInfoPtr_VideoAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct InitData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Cinematic;
    [FieldOffset(0)]
    public CinematicView.Cinematic Cinematic;

    static InitData()
    {
      Il2CppClassPointerStore<CinematicView.InitData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinematicView>.NativeClassPtr, nameof (InitData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinematicView.InitData>.NativeClassPtr);
      CinematicView.InitData.NativeFieldInfoPtr_Cinematic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinematicView.InitData>.NativeClassPtr, nameof (Cinematic));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CinematicView.InitData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  public enum Cinematic
  {
    None,
    VRising,
    Gloomrot,
  }
}
