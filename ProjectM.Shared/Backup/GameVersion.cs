// Decompiled with JetBrains decompiler
// Type: GameVersion
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
[StructLayout(LayoutKind.Explicit)]
public struct GameVersion
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Major;
  private static readonly System.IntPtr NativeFieldInfoPtr_Minor;
  private static readonly System.IntPtr NativeFieldInfoPtr_Patch;
  private static readonly System.IntPtr NativeFieldInfoPtr_Revision;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GameVersion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_GameVersion_GameVersion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_GameVersion_GameVersion_0;
  [FieldOffset(0)]
  public int Major;
  [FieldOffset(4)]
  public int Minor;
  [FieldOffset(8)]
  public int Patch;
  [FieldOffset(12)]
  public int Revision;

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 714212, RefRangeEnd = 714214, XrefRangeStart = 714189, XrefRangeEnd = 714212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(GameVersion.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(42)]
  [CachedScanResults(RefRangeStart = 261702, RefRangeEnd = 261744, XrefRangeStart = 261702, XrefRangeEnd = 261744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(GameVersion other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &other;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameVersion.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GameVersion_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 714214, RefRangeEnd = 714215, XrefRangeStart = 714214, XrefRangeEnd = 714214, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool operator <(GameVersion v1, GameVersion v2)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &v1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &v2;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameVersion.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_GameVersion_GameVersion_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public static unsafe bool operator >(GameVersion v1, GameVersion v2)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &v1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &v2;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameVersion.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_GameVersion_GameVersion_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  static GameVersion()
  {
    Il2CppClassPointerStore<GameVersion>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "", nameof (GameVersion));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameVersion>.NativeClassPtr);
    GameVersion.NativeFieldInfoPtr_Major = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameVersion>.NativeClassPtr, nameof (Major));
    GameVersion.NativeFieldInfoPtr_Minor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameVersion>.NativeClassPtr, nameof (Minor));
    GameVersion.NativeFieldInfoPtr_Patch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameVersion>.NativeClassPtr, nameof (Patch));
    GameVersion.NativeFieldInfoPtr_Revision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameVersion>.NativeClassPtr, nameof (Revision));
    GameVersion.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameVersion>.NativeClassPtr, 100663323);
    GameVersion.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GameVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameVersion>.NativeClassPtr, 100663324);
    GameVersion.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_GameVersion_GameVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameVersion>.NativeClassPtr, 100663325);
    GameVersion.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_GameVersion_GameVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameVersion>.NativeClassPtr, 100663326);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameVersion>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
