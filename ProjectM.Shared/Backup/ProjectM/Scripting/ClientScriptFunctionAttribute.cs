// Decompiled with JetBrains decompiler
// Type: ProjectM.Scripting.ClientScriptFunctionAttribute
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Scripting
{
  public class ClientScriptFunctionAttribute : Il2CppSystem.Attribute
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ClientScriptFunctionType_0;

    [CallerCount(19)]
    [CachedScanResults(RefRangeStart = 73013, RefRangeEnd = 73032, XrefRangeStart = 73013, XrefRangeEnd = 73032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ClientScriptFunctionAttribute(ClientScriptFunctionType type)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientScriptFunctionAttribute>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &type;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientScriptFunctionAttribute.NativeMethodInfoPtr__ctor_Public_Void_ClientScriptFunctionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ClientScriptFunctionAttribute()
    {
      Il2CppClassPointerStore<ClientScriptFunctionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Scripting", nameof (ClientScriptFunctionAttribute));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientScriptFunctionAttribute>.NativeClassPtr);
      ClientScriptFunctionAttribute.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientScriptFunctionAttribute>.NativeClassPtr, nameof (Type));
      ClientScriptFunctionAttribute.NativeMethodInfoPtr__ctor_Public_Void_ClientScriptFunctionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientScriptFunctionAttribute>.NativeClassPtr, 100668485);
    }

    public ClientScriptFunctionAttribute(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ClientScriptFunctionType Type
    {
      get
      {
        return *(ClientScriptFunctionType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientScriptFunctionAttribute.NativeFieldInfoPtr_Type));
      }
      [param: In] set
      {
        *(ClientScriptFunctionType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientScriptFunctionAttribute.NativeFieldInfoPtr_Type)) = value;
      }
    }
  }
}
