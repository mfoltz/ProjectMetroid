// Decompiled with JetBrains decompiler
// Type: ProjectM.ClanUtility
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class ClanUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSmartClanName_Public_Static_FixedString32_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetCharacterClanName_Public_Static_Void_EntityManager_Entity_FixedString64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 987008, RefRangeEnd = 987009, XrefRangeStart = 986987, XrefRangeEnd = 987008, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe FixedString32 GetSmartClanName(string clanname)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(clanname);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClanUtility.NativeMethodInfoPtr_GetSmartClanName_Public_Static_FixedString32_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(FixedString32*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 987021, RefRangeEnd = 987025, XrefRangeStart = 987009, XrefRangeEnd = 987021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetCharacterClanName(
      EntityManager entityManager,
      Entity userEntity,
      FixedString64 clanName)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &userEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &clanName;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClanUtility.NativeMethodInfoPtr_SetCharacterClanName_Public_Static_Void_EntityManager_Entity_FixedString64_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ClanUtility()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClanUtility>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClanUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ClanUtility()
    {
      Il2CppClassPointerStore<ClanUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ClanUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanUtility>.NativeClassPtr);
      ClanUtility.NativeMethodInfoPtr_GetSmartClanName_Public_Static_FixedString32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanUtility>.NativeClassPtr, 100676134);
      ClanUtility.NativeMethodInfoPtr_SetCharacterClanName_Public_Static_Void_EntityManager_Entity_FixedString64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanUtility>.NativeClassPtr, 100676135);
      ClanUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanUtility>.NativeClassPtr, 100676136);
    }

    public ClanUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
