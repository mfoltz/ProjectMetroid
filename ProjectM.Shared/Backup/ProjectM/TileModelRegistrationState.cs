// Decompiled with JetBrains decompiler
// Type: ProjectM.TileModelRegistrationState
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TileModelRegistrationState
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Registered;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TileModelRegistrationState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    [FieldOffset(0)]
    public bool Registered;

    [CallerCount(15)]
    [CachedScanResults(RefRangeStart = 731961, RefRangeEnd = 731976, XrefRangeStart = 731961, XrefRangeEnd = 731961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(TileModelRegistrationState other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileModelRegistrationState.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TileModelRegistrationState_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731976, XrefRangeEnd = 731977, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileModelRegistrationState.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731977, XrefRangeEnd = 731980, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileModelRegistrationState.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731980, XrefRangeEnd = 731986, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TileModelRegistrationState.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static TileModelRegistrationState()
    {
      Il2CppClassPointerStore<TileModelRegistrationState>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (TileModelRegistrationState));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileModelRegistrationState>.NativeClassPtr);
      TileModelRegistrationState.NativeFieldInfoPtr_Registered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelRegistrationState>.NativeClassPtr, nameof (Registered));
      TileModelRegistrationState.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TileModelRegistrationState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelRegistrationState>.NativeClassPtr, 100664667);
      TileModelRegistrationState.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelRegistrationState>.NativeClassPtr, 100664668);
      TileModelRegistrationState.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelRegistrationState>.NativeClassPtr, 100664669);
      TileModelRegistrationState.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelRegistrationState>.NativeClassPtr, 100664670);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileModelRegistrationState>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
