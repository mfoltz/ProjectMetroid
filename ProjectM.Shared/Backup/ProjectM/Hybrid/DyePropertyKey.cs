// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.DyePropertyKey
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Hybrid
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DyePropertyKey
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ShaderPropertyID;
    private static readonly System.IntPtr NativeFieldInfoPtr_RendererIndex;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DyePropertyKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    [FieldOffset(0)]
    public int ShaderPropertyID;
    [FieldOffset(4)]
    public int RendererIndex;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 261548, RefRangeEnd = 261550, XrefRangeStart = 261548, XrefRangeEnd = 261550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(DyePropertyKey other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DyePropertyKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DyePropertyKey_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 796126, XrefRangeEnd = 796129, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DyePropertyKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DyePropertyKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static DyePropertyKey()
    {
      Il2CppClassPointerStore<DyePropertyKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Hybrid", nameof (DyePropertyKey));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DyePropertyKey>.NativeClassPtr);
      DyePropertyKey.NativeFieldInfoPtr_ShaderPropertyID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyePropertyKey>.NativeClassPtr, nameof (ShaderPropertyID));
      DyePropertyKey.NativeFieldInfoPtr_RendererIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyePropertyKey>.NativeClassPtr, nameof (RendererIndex));
      DyePropertyKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DyePropertyKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DyePropertyKey>.NativeClassPtr, 100670254);
      DyePropertyKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DyePropertyKey>.NativeClassPtr, 100670255);
      DyePropertyKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DyePropertyKey>.NativeClassPtr, 100670256);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DyePropertyKey>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
